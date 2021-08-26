using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoImagem2
{
    public partial class SeparadorHorizontal : UserControl
    {
        //============================================================
        //separador Horizontal
        //============================================================
        private byte _alphaEscuro = 100;
        private byte _alphaClaro = 200;
        private Color _corEscura = Color.Black;
        private Color _corClara = Color.White;

        // implementar propriedades
        //-----------------------------------------------------------------
        public byte AlphaEscuro
        {
            get { return _alphaEscuro; }
            set
            {
                _alphaEscuro = value;
                SeparadorHorizontal_Resize(this, EventArgs.Empty);
            }
        }
        //-----------------------------------------------------------------
        public byte AlphaClaro
        {
            get { return _alphaClaro; }
            set
            {
                _alphaEscuro = value;
                SeparadorHorizontal_Resize(this, EventArgs.Empty);
            }
        }
        //-----------------------------------------------------------------
        public Color CorEscura
        {
            get { return _corEscura; }
            set
            {
                _corEscura = value;
                SeparadorHorizontal_Resize(this, EventArgs.Empty);
            }
        }
        //------------------------------------------------------------------
        public Color CorClara
        {
            get { return _corClara; }
            set
            {
                _corClara = value;
                SeparadorHorizontal_Resize(this, EventArgs.Empty);
            }
        }
        //-----------------------------------------------------------------

        public SeparadorHorizontal()
        {
            InitializeComponent();
            //caracteristicas genericas
            this.BackColor = Color.Transparent;
            this.BackgroundImageLayout = ImageLayout.None;
        }

        //=====================================================================
        private void SeparadorHorizontal_Load(object sender, EventArgs e)
        {
             
        }
        //=====================================================================
        private void SeparadorHorizontal_Resize(object sender, EventArgs e)
        {
            //desenhar as linhas () aspecto Visual
            this.Height = 4;
            Bitmap imgback = new Bitmap(this.Width, this.Height);
            Graphics desenhador = Graphics.FromImage(imgback);

            //Criar as Pens (canetas)

            Pen corEscura = new Pen(Color.FromArgb(_alphaEscuro, _corEscura), 1);
            Pen corClara  = new Pen(Color.FromArgb(_alphaClaro, _corClara), 1);


            //desenhar as linhas

            //Parte escura
            desenhador.DrawLine(corEscura, new Point(1, 1), new Point(this.Width - 3,1));
            desenhador.DrawLine(corEscura, new Point(1, 1), new Point(1, 2));

            // parte Clara

            desenhador.DrawLine(corClara, new Point(2, 2), new Point(this.Width - 2, 2));
            desenhador.DrawLine(corClara, new Point(this.Width - 2, 1), new Point(this.Width - 2, 2));

            this.BackgroundImage = imgback;
        }
    }
}
