namespace Flyweight;

public partial class Painter : Form
{
    private readonly int WIDTH;
        private readonly int HEIGHT;

        private static readonly ShapeType[] shapes = { ShapeType.LINE, ShapeType.OVAL_FILL, ShapeType.OVAL_NOFILL, ShapeType.SQUARE_FILL, ShapeType.SQUARE_NOFILL, ShapeType.TRIANGLE_FILL, ShapeType.TRIANGLE_NOFILL };
        private static readonly Color[] colors = { Color.Red, Color.Green, Color.Yellow, Color.Aquamarine, Color.Chartreuse, Color.Black, Color.Indigo };

        public Painter(int width, int height)
        {
            this.WIDTH = width;
            this.HEIGHT = height;

            var contentPane = Controls;

            var startButton = new Button { Text = "Draw" };
            var panel = new Panel { Dock = DockStyle.Fill };

            contentPane.Add(panel);
            contentPane.Add(startButton);
            startButton.Dock = DockStyle.Bottom;

            Visible = true;
            Size = new Size(WIDTH, HEIGHT);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;

            startButton.Click += (sender, e) =>
            {
                var g = panel.CreateGraphics();
                for (int i = 0; i < 20; ++i)
                {
                    var shape = ShapeFactory.GetShape(GetRandomShape());
                    shape.Draw(g, GetRandomX(), GetRandomY(), GetRandomWidth(),
                            GetRandomHeight(), GetRandomColor());
                }
            };
        }

        private ShapeType GetRandomShape()
        {
            var random = new Random();
            return shapes[random.Next(shapes.Length)];
        }

        private int GetRandomX()
        {
            var random = new Random();
            return random.Next(WIDTH);
        }

        private int GetRandomY()
        {
            var random = new Random();
            return random.Next(HEIGHT);
        }

        private int GetRandomWidth()
        {
            var random = new Random();
            return random.Next(WIDTH / 10);
        }

        private int GetRandomHeight()
        {
            var random = new Random();
            return random.Next(HEIGHT / 10);
        }

        private Color GetRandomColor()
        {
            var random = new Random();
            return colors[random.Next(colors.Length)];
        }
        
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Painter(1024, 768));
        }
}