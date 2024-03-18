List<IShape> shapes = new List<IShape>() { new LineAdapter(new LegacyLine()), new RectangleAdapter(new LegacyRectangle()) };

int x1 = 5, y1 = 10, x2 = -3, y2 = 2;

shapes.ForEach(shape => shape.Draw(x1, y1, x2, y2));


