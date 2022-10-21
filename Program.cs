using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNamespace
{
    class Shapes
    {
    public interface Shape{
        string ToString();        
    }
    public class Circle : Shape{
        public int radius{get; set;}
        public int x{get; set;}
        public int y{get; set;}
        public Circle(int x, int y, int radius){
            this.x = x;
            this.y = y;
            this.radius = radius;
        }
        public override string ToString(){
            return "<circle cx=\""+ x+"\" cy=\""+y+"\" r= \""+radius+"\" />";
        }
    }
    public class Rectangle : Shape{

        public int x{get; set;}
        public int y{get; set;}
        public Rectangle(int x, int y){
            this.x = x;
            this.y = y;
        }

        public override string ToString(){
            return "<rect x=\""+ x+"\" y=\""+y+"\" width=\"100\" height=\"100\" />";
        }
    }
    public class Ellipse : Shape{
        public int rx{get; set;}
        public int ry{get; set;}
        public int x{get; set;}
        public int y{get; set;}
        public Ellipse(int x, int y, int rx, int ry){
            this.x = x;
            this.y = y;
            this.rx = rx;
            this.ry = ry;
        }

        public override string ToString(){
            return "<ellipse cx=\""+ x+"\" cy=\""+y+"\" rx=\""+rx+"\" ry=\""+ry+"\" />";
        }
    }
    public class Line : Shape{
        public int x1{get; set;}
        public int y1{get; set;}
        public int x2{get; set;}
        public int y2{get; set;}
        public Line(int x1, int y1, int x2, int y2){
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }
        public override string ToString(){
            return "<line x1=\""+ x1+"\" y1=\""+y1+"\" x2=\""+x2+"\" y2=\""+y2+"\" />";
            }
    }
    public class Polyline : Shape{
        public int x1{get; set;}
        public int y1{get; set;}
        public int x2{get; set;}
        public int y2{get; set;}
        public int x3{get; set;}
        public int y3{get; set;}
        public int x4{get; set;}
        public int y4{get; set;}
        public Polyline(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4){
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3 = y3;
            this.x4 = x4;
            this.y4 = y4;
        }

        public override string ToString(){
            return "<polyline points=\""+ x1+","+y1+" "+x2+","+y2+" "+x3+","+y3+" "+x4+","+y4+"\" />";
        }
    }
    public class Polygon : Shape{
        public int x1{get; set;}
        public int y1 {get; set;}
        public int x2 {get; set;}
        public int x3 {get; set;}
        public int y2 {get; set;}
        public int y3 {get; set;}
        public int x4 {get; set;}
        public int y4 {get; set;}
        public Polygon(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4){
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3 = y3;
            this.x4 = x4;
            this.y4 = y4;
        }

        public override string ToString(){
            return "<polygon points=\""+ x1+","+y1+" "+x2+","+y2+" "+x3+","+y3+" "+x4+","+y4+"\" />";
        }
    }
    public class Path : Shape{
        public int x1{get; set;}
        public int y1 {get; set;}
        public int x2 {get; set;}
        public int y2 {get; set;}
        public int x3 {get; set;}
        public int y3 {get; set;}
        public int x4 {get; set;}
        public int y4 {get; set;}
        public Path(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4){
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3 = y3;
            this.x4 = x4;
            this.y4 = y4;
        }
    
        public override string ToString(){
            return "<path d=\"M"+ x1+","+y1+" L"+x2+","+y2+" L"+x3+","+y3+" L"+x4+","+y4+" Z\" />";
        }
    }
        static void Main(string[] args){
            List<string> canvas = new List<string>();
            string svgOpen = @"<svg height=""400"" width=""400"" xmlns=""http://www.w3.org/2000/svg"">" + Environment.NewLine;
            string svgClose = Environment.NewLine + @"</svg>";
            canvas.Add(svgOpen);
            Console.WriteLine("Would you like to create, delete, or modify a shape?");
            // Console.WriteLine(" Functonality to set default line and fill styles for individual shape types, for example, default rectangles are grey with black 1pt solid line borders");
            bool exit = false;
            int zIndex =0;
            Console.Clear();
            while(exit == false){
                for(int i=0;i<canvas.Count;i++)
                    {
                    Console.WriteLine(canvas[i]);
                    Console.WriteLine(canvas.Count);
                    }
                Console.WriteLine("Choose command below: ");
                Console.WriteLine("0): Exit");
                Console.WriteLine("1): Create Rectangle");
                Console.WriteLine("2): Create Circle");
                Console.WriteLine("3): Create Ellipse");
                Console.WriteLine("4): Create Line");
                Console.WriteLine("5): Create Polyline");
                Console.WriteLine("6): Create Polygon");
                Console.WriteLine("7): Create Path");
                Console.WriteLine("8): Done?");
                int choice = int.Parse (Console.ReadLine());
                    if(choice ==1){
                        //create rectangle
                        Console.WriteLine("Enter x coordinate: ");
                        int x = int.Parse(Console.ReadLine()) ;
                        Console.WriteLine("Enter y coordinate: ");
                        int y = int.Parse(Console.ReadLine()) ;
                        Rectangle rect = new Rectangle(x, y);
                        canvas.Add(rect.ToString());
                        Console.WriteLine(rect.ToString());
                    
                    }

                    else if (choice == 2){
                        //Circle
                        Console.WriteLine("Enter x coordinate: ");
                        int x = int.Parse(Console.ReadLine()) ;
                        Console.WriteLine("Enter y coordinate: ");
                        int y = int.Parse(Console.ReadLine()) ;
                        Console.WriteLine("Enter radius: ");
                        int radius = int.Parse(Console.ReadLine());

                        Circle currentShape = new  Circle(x,y,radius);
                        canvas.Add(currentShape.ToString());
                    }
                    else if (choice == 3){
                        //Ellipse
                        Console.WriteLine("Enter x coordinate: ");
                        int x = int.Parse(Console.ReadLine()) ;
                        Console.WriteLine("Enter y coordinate: ");
                        int y = int.Parse(Console.ReadLine()) ;
                        Console.WriteLine("Enter radiusX: ");
                        int rx = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter radius Y: ");
                        int ry = int.Parse(Console.ReadLine());
                        Ellipse currentShape = new Ellipse(x,y,rx,ry);
                        canvas.Add(currentShape.ToString());
                    }
                    else if (choice == 4){
                        //Line
                        Console.WriteLine("Enter x1 coordinate: ");
                        int x1 = int.Parse(Console.ReadLine()) ;
                        Console.WriteLine("Enter y1 coordinate: ");
                        int y1 = int.Parse(Console.ReadLine()) ;
                        Console.WriteLine("Enter x2 coordinate: ");
                        int x2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter y2 coordinate: ");
                        int y2 = int.Parse(Console.ReadLine());

                        Line currentShape = new Line(x1,y1,x2,y2);
                        canvas.Add(currentShape.ToString());

                    }
                    else if (choice == 5){
                        //Polyline
                        Console.WriteLine("Enter x1 coordinate: ");
                        int x1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter y1 coordinate: ");
                        int y1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter x2 coordinate: ");
                        int x2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter y2 coordinate: ");
                        int y2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter x3 coordinate: ");
                        int x3 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter y3 coordinate: ");
                        int y3 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter x4 coordinate: ");
                        int x4 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter y4 coordinate: ");
                        int y4 = int.Parse(Console.ReadLine());

                        Polyline currentShape = new Polyline(x1,y1,x2,y2,x3,y3,x4,y4);
                        
                        canvas.Add(currentShape.ToString());
                    }
                    else if (choice == 6){
                        //Polygon
                        Console.WriteLine("Enter x1 coordinate: ");
                        int x1 = int.Parse(Console.ReadLine()) ;
                        Console.WriteLine("Enter y1 coordinate: ");
                        int y1 = int.Parse(Console.ReadLine()) ;
                        Console.WriteLine("Enter x2 coordinate: ");
                        int x2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter y2 coordinate: ");
                        int y2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter x3 coordinate: ");
                        int x3 = int.Parse(Console.ReadLine()) ;
                        Console.WriteLine("Enter y3 coordinate: ");
                        int y3 = int.Parse(Console.ReadLine()) ;
                        Console.WriteLine("Enter x4 coordinate: ");
                        int x4 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter y4 coordinate: ");
                        int y4 = int.Parse(Console.ReadLine());

                        Polygon currentShape = new Polygon(x1,y1,x2,y2,x3,y3,x4,y4);
                        canvas.Add(currentShape.ToString());
                    }
                    else if (choice == 7){
                        //Path
                        Console.WriteLine("Enter x1 coordinate: ");
                        int x1 = int.Parse(Console.ReadLine()) ;
                        Console.WriteLine("Enter y1 coordinate: ");
                        int y1 = int.Parse(Console.ReadLine()) ;
                        Console.WriteLine("Enter x2 coordinate: ");
                        int x2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter y2 coordinate: ");
                        int y2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter x3 coordinate: ");
                        int y3 = int.Parse(Console.ReadLine()) ;
                        Console.WriteLine("Enter y3 coordinate: ");
                        int x3 = int.Parse(Console.ReadLine()) ;
                        Console.WriteLine("Enter x4 coordinate: ");
                        int x4 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter y4 coordinate: ");
                        int y4 = int.Parse(Console.ReadLine());

                        Path currentShape = new Path(x1,y1,x2,y2,x3,y3,x4,y4);

                        canvas.Add(currentShape.ToString());
                    }
                    else if(choice==8){
                        canvas.Add(svgClose);

                        System.IO.File.WriteAllLines("Shape.svg", canvas);
                        break;
                    }
                    else if (choice ==0){
                        break;
                    }
                    else{
                        Console.WriteLine("Invalid choice");
                    }
            }
        }
    }       
}  
