using System.Windows.Forms;

public class ControlPositioning
{
    public static Point ControlAlignment (Control c)
    {
        return new Point((c.Location.X + c.Size.Width)/2, (c.Location.Y + c.Size.Height)/2); 
    }

    public static Point ControlAlignment (Form f, Control c)
    {
        f.Controls.Add(c);
        return new Point((c.Location.X + c.Size.Width)/2, (c.Location.Y + c.Size.Height)/2); 
    }

    public static Point ControlAlignment (Panel p, Control c)
    {
        p.Controls.Add(c);
        return new Point((c.Location.X + c.Size.Width)/2, (c.Location.Y + c.Size.Height)/2); 
    }
}