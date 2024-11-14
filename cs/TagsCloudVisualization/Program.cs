using System.Drawing;
using TagsCloudVisualization;

var Sizes = new List<Size>();
for (int i = 10; i < 100; i += 10)
    for (int j = 10; j < 50; j += 10)
        Sizes.Add(new Size(i, j));
Sizes = Sizes.OrderByDescending(s => s.Width * s.Height).ToList();
var Layouter = new CircularCloudLayouter(new Point(400, 400));
foreach (var size in Sizes)
    Layouter.PutNextRectangle(size);

var drawer = new ImageCreater(Layouter.Center.X * 2, Layouter.Center.Y * 2);
drawer.Generate(Layouter.Rectangles);