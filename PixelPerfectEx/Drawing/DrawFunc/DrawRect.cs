using Dalamud.Utility.Numerics;
using ImGuiNET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PixelPerfectEx.Drawing.DrawFunc
{
    internal class DrawRect
    {
        internal static void Draw(ImDrawListPtr drawList, Vector3 centre,float Length, float Width, float rot,uint Color)
        {
            var a = new Vector3(
                    centre.X + Width / 2f * MathF.Sin(-MathF.PI / 2f + rot),
                    centre.Y,
                    centre.Z + Width / 2f * MathF.Cos(-MathF.PI / 2f + rot));
            var d = new Vector3(
                centre.X + Width / 2f * MathF.Sin(MathF.PI / 2f + rot),
                centre.Y,
                centre.Z + Width / 2f * MathF.Cos(MathF.PI / 2f + rot));
            var b = new Vector3(
                a.X + Length * MathF.Sin(rot),
                a.Y,
                a.Z + Length * MathF.Cos(rot));
            var c = new Vector3(
                d.X + Length * MathF.Sin(rot),
                d.Y,
                d.Z + Length * MathF.Cos(rot));



            var l1 = PointHelper.GetPionts(a, b);
            var l2 = PointHelper.GetPionts(b, c);
            var l3 = PointHelper.GetPionts(c, d);
            var l4 = PointHelper.GetPionts(d, a);
            l1.ForEach(p => drawList.PathLineToMergeDuplicate(p));
            l2.ForEach(p => drawList.PathLineToMergeDuplicate(p));
            l3.ForEach(p => drawList.PathLineToMergeDuplicate(p));
            l4.ForEach(p => drawList.PathLineToMergeDuplicate(p));

            drawList.PathFillConvex(Color);
            drawList.PathClear();
            if (Service.Configuration.Strock)
            {
                var colStock = ImGui.ColorConvertU32ToFloat4(Color).WithW(1);
                l1.ForEach(p => drawList.PathLineToMergeDuplicate(p));
                l2.ForEach(p => drawList.PathLineToMergeDuplicate(p));
                l3.ForEach(p => drawList.PathLineToMergeDuplicate(p));
                l4.ForEach(p => drawList.PathLineToMergeDuplicate(p));
                drawList.PathStroke(ImGui.ColorConvertFloat4ToU32(colStock), ImDrawFlags.Closed, Service.Configuration.StrockWidth);
            }
        }
        
    }

}
