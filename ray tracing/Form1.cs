using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace ray_tracing
{
    public partial class Form1 : Form
    {
        bool loaded = false;
        View view;

        public Form1()
        {
            InitializeComponent();
            view = new View();
        }

        private void glControl1_Paint(object sender, PaintEventArgs e)
        {
            if (!loaded) return;
            view.Update();
            glControl1.SwapBuffers();
            GL.UseProgram(0);
        }

        private void glControl1_Load(object sender, EventArgs e)
        {
            loaded = true;
            view.Setup(glControl1.Width, glControl1.Height);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            view.InitBuffer();
            int reflect = GL.GetUniformLocation(view.BasicProgramID, "ReflectC");
            GL.Uniform1(reflect, trackBar1.Value);
            view.Update();
            glControl1.SwapBuffers();
            GL.UseProgram(0);
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            view.InitBuffer();
            int color = GL.GetUniformLocation(view.BasicProgramID, "ColorR");
            GL.Uniform1(color, trackBar2.Value);
            view.Update();
            glControl1.SwapBuffers();
            GL.UseProgram(0);
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            view.InitBuffer();
            int color = GL.GetUniformLocation(view.BasicProgramID, "ColorG");
            GL.Uniform1(color, trackBar3.Value);
            view.Update();
            glControl1.SwapBuffers();
            GL.UseProgram(0);
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            view.InitBuffer();
            int color = GL.GetUniformLocation(view.BasicProgramID, "ColorB");
            GL.Uniform1(color, trackBar4.Value);
            view.Update();
            glControl1.SwapBuffers();
            GL.UseProgram(0);
        }

        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            view.InitBuffer();
            int depth = GL.GetUniformLocation(view.BasicProgramID, "RaytraceDepth");
            GL.Uniform1(depth, trackBar5.Value);
            view.Update();
            glControl1.SwapBuffers();
            GL.UseProgram(0);
        }
    }
}
