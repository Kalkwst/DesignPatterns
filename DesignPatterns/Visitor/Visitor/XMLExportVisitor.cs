using System.Text;
using System.Xml.Linq;
using Visitor.Shapes;

namespace Visitor.Visitor
{
    public class XMLExportVisitor : IVisitor
    {
        public string Export(params IShape[] shapes)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
            builder.AppendLine("<shapes>");

            foreach (IShape shape in shapes)
                builder.AppendLine(shape.Accept(this));

            builder.AppendLine("</shapes>");
            return XMLFormatter(builder.ToString());
        }

        public string VisitCircle(Circle circle)
        {
            return $@"<circle> 
                          <id>{circle.Id}</id> 
                          <x>{circle.X}</x> 
                          <y>{circle.Y}</y> 
                          <radius>{circle.Radius}</radius> 
                      </circle>";
        }

        public string VisitComplex(ComplexShape complexShape)
        {
            return $@"<complex> 
                          <id>{complexShape.Id}</id> 
                          {VisitChildren(complexShape)}
                      </complex>";

        }

        public string VisitDot(Dot dot)
        {
            return $@"<dot> 
                      <id>{dot.Id}</id> 
                      <x>{dot.X}</x> 
                      <y>{dot.Y}</y> 
                      </dot>";
        }

        public string VisitRectangle(Rectangle rectangle)
        {
            return $@"<rectangle> 
                          <id>{rectangle.Id}</id> 
                          <x>{rectangle.X}</x> 
                          <y>{rectangle.Y}</y> 
                          <width>{rectangle.Width}</width> 
                          <height>{rectangle.Height}</height> 
                      </rectangle>";
        }

        private string VisitChildren(ComplexShape shape)
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (IShape child in shape.children)
            {
                string childXML = child.Accept(this);
                stringBuilder.AppendLine(childXML);
            }

            return stringBuilder.ToString();
        }

        private string XMLFormatter(string xml)
        {
            XDocument doc = XDocument.Parse(xml);
            return doc.ToString();
        }
    }
}
