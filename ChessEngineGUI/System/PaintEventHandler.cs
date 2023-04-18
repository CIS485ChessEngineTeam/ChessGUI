namespace System
{
    internal class PaintEventHandler
    {
        private Action<EventArgs, Graphics> repaint;

        public PaintEventHandler(Action<EventArgs, Graphics> repaint)
        {
            this.repaint = repaint;
        }
    }
}