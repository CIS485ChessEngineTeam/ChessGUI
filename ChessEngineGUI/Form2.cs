using Rudzoft.ChessLib;
using Rudzoft.ChessLib.Factories;
using Rudzoft.ChessLib.MoveGeneration;
using Rudzoft.ChessLib.Notation.Notations;
using Rudzoft.ChessLib.Protocol.UCI;
using Rudzoft.ChessLib.Types;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ChessEngineGUI
{
    public partial class Form2 : Form
    {
        private Boolean againstEngine;
        private System.Diagnostics.Process engine;
        private Boolean waitingOnEngine;
        public Point mouseLocation;
        private IGame game;
        private Image defaultImage;
        private List<string> history;
        private int movetime;
        private string score;

        public Form2(string chessEnginePath, Boolean againstEngine, int movetime)
        {
            InitializeComponent();
            this.defaultImage = (Image)boardPicture.Image.Clone();
            boardPicture.Click += new System.EventHandler(pictureBox1_Click);
            boardPicture.Paint += new System.Windows.Forms.PaintEventHandler(Repaint);
            this.movetime = movetime;
            if (againstEngine)
            {
                engine = new System.Diagnostics.Process();
                engine.StartInfo.CreateNoWindow = true;
                engine.StartInfo.FileName = "java";
                engine.StartInfo.Arguments = @"-jar " + chessEnginePath;
                engine.StartInfo.UseShellExecute = false;
                engine.StartInfo.RedirectStandardInput = true;
                engine.StartInfo.RedirectStandardOutput = true;
                engine.StartInfo.RedirectStandardError = true;
                engine.OutputDataReceived += new DataReceivedEventHandler(EngineOutputHandler);
                engine.ErrorDataReceived += new DataReceivedEventHandler(EngineErrorHandler);
                engine.Start();
                engine.BeginOutputReadLine();
                engine.BeginErrorReadLine();
                //engine.WaitForExit();
            }

            game = GameFactory.Create("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1");
            this.againstEngine = againstEngine;
            this.waitingOnEngine = false;
            this.history = new List<string>();
            SignalRepaint();
        }

        private void DrawBoardState(Graphics g)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Square square = new Square(GetRank(i + 1), GetFile(j + 1));
                    Piece piece = game.Pos.GetPiece(square);
                    if (piece != Piece.EmptyPiece)
                    {
                        Image pieceImage = null;
                        PieceTypes type = piece.Type();
                        if (piece.ColorOf() == Player.White)
                        {
                            switch (type)
                            {
                                case PieceTypes.Pawn:
                                    pieceImage = PieceImages.WHITE_PAWN;
                                    break;
                                case PieceTypes.Rook:
                                    pieceImage = PieceImages.WHITE_ROOK;
                                    break;
                                case PieceTypes.Knight:
                                    pieceImage = PieceImages.WHITE_KNIGHT;
                                    break;
                                case PieceTypes.Bishop:
                                    pieceImage = PieceImages.WHITE_BISHOP;
                                    break;
                                case PieceTypes.Queen:
                                    pieceImage = PieceImages.WHITE_QUEEN;
                                    break;
                                case PieceTypes.King:
                                    pieceImage = PieceImages.WHITE_KING;
                                    break;
                            }

                        }
                        else
                        {
                            switch (type)
                            {
                                case PieceTypes.Pawn:
                                    pieceImage = PieceImages.BLACK_PAWN;
                                    break;
                                case PieceTypes.Rook:
                                    pieceImage = PieceImages.BLACK_ROOK;
                                    break;
                                case PieceTypes.Knight:
                                    pieceImage = PieceImages.BLACK_KNIGHT;
                                    break;
                                case PieceTypes.Bishop:
                                    pieceImage = PieceImages.BLACK_BISHOP;
                                    break;
                                case PieceTypes.Queen:
                                    pieceImage = PieceImages.BLACK_QUEEN;
                                    break;
                                case PieceTypes.King:
                                    pieceImage = PieceImages.BLACK_KING;
                                    break;
                            }
                        }
                        g.DrawImage(pieceImage, new Point(W * (j) + DX, W * (7 - i) + DY));
                    }
                }
            }

            if (selected)
            {
                g.FillRectangle(new SolidBrush(Color.FromArgb(75, 0, 255, 255)), new Rectangle(W * (selectedFile - 1), W * (8 - selectedRank), W, W));
            }
        }

        private void Repaint(object? sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(defaultImage, 0, 0);
            DrawBoardState(g);
        }



        private void SignalRepaint()
        {
            boardPicture.Invalidate();
            double value;
            if (Double.TryParse(score, out value))
            {
                value = Math.Round(value * 10) / 10;
                scoreText.Text = "Score: " + value;
            }
            //boardPicture.Image = (Image)defaultImage.Clone();
            //Graphics g = Graphics.FromImage(boardPicture.Image);
            //drawBoardState(g, boardPicture.Image);

        }

        private const int W = 60;
        private const int DX = -3;
        private const int DY = -2;

        private Files GetFile(int f)
        {
            switch (f)
            {
                case 1: return Files.FileA;
                case 2: return Files.FileB;
                case 3: return Files.FileC;
                case 4: return Files.FileD;
                case 5: return Files.FileE;
                case 6: return Files.FileF;
                case 7: return Files.FileG;
                case 8: return Files.FileH;
                default: return Files.FileNb;
            }
        }

        private Ranks GetRank(int r)
        {
            switch (r)
            {
                case 1: return Ranks.Rank1;
                case 2: return Ranks.Rank2;
                case 3: return Ranks.Rank3;
                case 4: return Ranks.Rank4;
                case 5: return Ranks.Rank5;
                case 6: return Ranks.Rank6;
                case 7: return Ranks.Rank7;
                case 8: return Ranks.Rank8;
                default: return Ranks.RankNb;
            }
        }

        private int selectedFile;
        private int selectedRank;
        private bool selected = false;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (waitingOnEngine)
            {
                return;
            }
            int x = MousePosition.X - this.Location.X - boardPicture.Location.X;
            int y = MousePosition.Y - this.Location.Y - boardPicture.Location.Y;
            int file = x / W + 1;
            int rank = y / W;
            rank = 8 - rank;
            if (file >= 1 && file <= 8 && rank >= 1 && rank <= 8)
            {
                if (!selected)
                {
                    selectedFile = file;
                    selectedRank = rank;
                    selected = true;
                    SignalRepaint();
                }
                else
                {
                    Square from = Square.Create(GetRank(selectedRank), GetFile(selectedFile));
                    Square to = Square.Create(GetRank(rank), GetFile(file));
                    Move move = new Move(from, to);
                    bool isValidMove = IsLegal(move);
                    if (isValidMove)
                    {
                        DoMove(move);
                        if (resetOnTerminalState())
                        {
                            return;
                        }
                    }

                    if (isValidMove)
                    {
                        if (againstEngine)
                        {
                            RunEngine();
                        }
                    }

                    selected = false;
                    SignalRepaint();
                }
            }
            else
            {
                selected = false;
                SignalRepaint();
            }
        }

        private bool IsLegal(Move move)
        {
            return game.Pos.GenerateMoves().Contains(move);
        }

        private void DoMove(Move move)
        {
            if (IsLegal(move))
            {
                history.Add(game.Pos.GenerateFen().ToString());
                game.Pos.MakeMove(move, game.Pos.State);
                SignalRepaint();
                resetOnTerminalState();
            }
        }

        private bool resetOnTerminalState()
        {
            if (game.Pos.IsMate || game.Pos.IsDraw(game.Pos.Rule50))
            {
                selected = false;
                boardPicture.Invalidate();
                string s = "";
                if (game.Pos.IsDraw(game.Pos.Rule50))
                {
                    s = "Draw!";
                }
                else
                {
                    if (game.Pos.SideToMove == Player.White)
                    {
                        s = "Black wins!";
                    }
                    else
                    {
                        s = "White wins!";
                    }
                }
                System.Windows.Forms.MessageBox.Show(s);
                game = GameFactory.Create("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1");
                selected = false;
                SignalRepaint();
                return true;
            }
            return false;
        }


        private void EngineOutputHandler(object sendingProcess, DataReceivedEventArgs outline)
        {
            if (outline.Data == null)
            {
                return;
            }
            string s = outline.Data;
            string[] parts = s.Split(' ');
            if (parts[0].Equals("bestmove"))
            {
                string bestmove = parts[1];
                score = parts[2];
                MoveList moves = game.Pos.GenerateMoves();
                foreach (Move move in moves)
                {
                    if (move.ToString().Equals(bestmove))
                    {
                        DoMove(move);
                        waitingOnEngine = false;
                        break;
                    }
                }
            }
        }

        private void EngineErrorHandler(object sendingProcess, DataReceivedEventArgs outline)
        {
            string s = outline.Data;
            Debug.WriteLine(s);
        }

        private async void RunEngine()
        {
            string fen = game.Pos.GenerateFen().Fen.ToString();
            waitingOnEngine = true;
            await engine.StandardInput.WriteLineAsync("position fen " + fen);
            await engine.StandardInput.WriteLineAsync("go movetime " + movetime);

        }

        private void mouse_down(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
            Debug.WriteLine(mouseLocation.X);
        }

        private void mouse_move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            if (!waitingOnEngine)
            {
                selected = false;
                game = GameFactory.Create("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1");
                history.Clear();
                SignalRepaint();
            }
        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            if (!waitingOnEngine && history.Count() > 0)
            {
                selected = false;
                game = GameFactory.Create(history.Last());
                history.RemoveAt(history.Count() - 1);
                SignalRepaint();
            }
        }
    }
}
