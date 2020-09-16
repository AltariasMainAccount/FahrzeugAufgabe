using Fahrzeuge_Projekt.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fahrzeuge_Projekt
{
    class AutoImage
    {
        private PictureBox _image;
        private char _direction;

        public AutoImage(Form parent, char direction, Lane lane)
        {
            _direction = direction;
            _image = new PictureBox
            {
                BackColor = System.Drawing.Color.Transparent,
                BackgroundImage = global::Fahrzeuge_Projekt.Properties.Resources.BlueCar_Small,
                BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch,
                Location = new System.Drawing.Point(981, 163),
                Name = "BlackCar",
                Size = new System.Drawing.Size(195, 94),
            };

            parent.Controls.Add(_image);
        }

        public void moveCar()
        {
            if (_direction == 'r')
            {
                _image.Location = new Point(_image.Location.X + 3, _image.Location.Y);
            }
            else if (_direction == 'l')
            {
                _image.Location = new Point(_image.Location.X - 3, _image.Location.Y);
            }
            else
            {
                throw new InvalidOperationException("Parameter Error -> Direction is invalid or missing");
            }
        }
    }
}
