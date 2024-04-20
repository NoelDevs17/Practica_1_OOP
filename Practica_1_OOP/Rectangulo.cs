﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_OOP
{
    internal class Rectangulo : Figura
    {

        private double baseRectangulo;
        private double alturaRectangulo;

        public Rectangulo(double baseRectangulo, double alturaRectangulo)
        {
            this.baseRectangulo = baseRectangulo;
            this.alturaRectangulo = alturaRectangulo;
        }

        public override double CalcularArea()
        {
            return baseRectangulo * alturaRectangulo;
        }
    }
}
