using System.Collections;
using System.Collections.Generic;
using UnityEngine;



    public class Matriz2x2 
    {

        /* La primera entrada de la matriz. */
        private double a;
        /* La segunda entrada de la matriz. */
        private double b;
        /* La tercera entrada de la matriz. */
        private double c;
        /* La cuarta entrada de la matriz. */
        private double d;

        /**
         * Constructor único. Dado que no proveemos <em>setters</em>, nuestras
         * matrices de 2×2 son <em>inmutables</em>; no podemos cambiar sus valores.
         * @param a la primera entrada de la matriz.
         * @param b la segunda entrada de la matriz.
         * @param c la tercera entrada de la matriz.
         * @param d la cuarta entrada de la matriz.
         */
        public Matriz2x2(double a, double b,
                         double c, double d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            // Aquí va su código.
        }

        /**
         * Regresa el elemento <tt>a</tt> de la matriz de 2×2.
         * @return El elemento <tt>a</tt> de la matriz de 2×2.
         */
        public double GetA()
        {
            return a;
        }

        /**
         * Regresa el elemento <tt>b</tt> de la matriz de 2×2.
         * @return El elemento <tt>b</tt> de la matriz de 2×2.
         */
        public double GetB()
        {
            // Aquí va su código.
            return b;
        }

        /**
         * Regresa el elemento <tt>c</tt> de la matriz de 2×2.
         * @return El elemento <tt>c</tt> de la matriz de 2×2.
         */
        public double GetC()
        {
            // Aquí va su código.
            return c;
        }

        /**
         * Regresa el elemento <tt>d</tt> de la matriz de 2×2.
         * @return El elemento <tt>d</tt> de la matriz de 2×2.
         */
        public double GetD()
        {
            // Aquí va su código.
            return d;
        }

        /**
         * Suma la matriz de 2×2 con la matriz de 2×2 que recibe como parámetro.
         * @param m La matriz de 2×2 con la que hay que sumar.
         * @return La suma con la matriz de 2×2 <tt>m</tt>.
         */
        public Matriz2x2 Suma(Matriz2x2 m)
        {
            // Aquí va su código.
            Matriz2x2 n = new Matriz2x2(a + m.GetA(), b + m.GetB(), c + m.GetC(), d + m.GetC());
            return n;
        }

        /**
         * Multiplica la matriz de 2×2 con la matriz de 2×2 que recibe como
         * parámetro.
         * @param m La matriz de 2×2 con la que hay que multiplicar.
         * @return La multiplicación con la matriz de 2×2 <tt>m</tt>.
         */
        public Matriz2x2 Multiplica(Matriz2x2 m)
        {
            // Aquí va su código.
            double a2 = (a * m.GetA()) + (b * m.GetC());
            double b2 = (a * m.GetB()) + (b * m.GetD());
            double c2 = (c * m.GetA()) + (d * m.GetC());
            double d2 = (c * m.GetB()) + (d * m.GetD());

        

            Matriz2x2 l = new Matriz2x2(a2, b2, c2, d2);
            return l;
            
        }

        /**
         * Multiplica la matriz de 2×2 con la constante que recibe como parámetro.
         * @param x La constante con la que hay que multiplicar.
         * @return La multiplicación con la constante <tt>x</tt>.
         */
        public Matriz2x2 MultiplicaC(double x)
        {
            Matriz2x2 k = new Matriz2x2(x * a, x * b, x * c, x * d);
            return k;
           
        }

        /**
         * Calcula el determinante de la matriz de 2×2.
         * @return El determinante de la matriz de 2×2.
         */
        public double Determinante()
        {
          double a3 = a * d;
          double b3 = c * b;

           double res = a3 - b3; 

           return res;
            
        }

        /**
         * Calcula la inversa de la matriz de 2×2.
         *
         * Si multiplicamos una matriz de 2×2 con su inversa, obtenemos la matriz
         * identidad.
         * @return La inversa de la matriz de 2×2, o <tt>null</tt> si la matriz no
         *         es inversible.
         */


        


    public Matriz2x2 Inversa(Matriz2x2 m)
     {
        double det = Determinante();
        if (det == 0.0)
            return null;

        Matriz2x2 Adj = new Matriz2x2(m.GetD(), -(m.GetC()), -(m.GetB()), m.GetA());
        //Debug.Log ("Adjunta: " + Adj);

        Matriz2x2 tras = new Matriz2x2(m.GetD(), -(m.GetB()), -(m.GetC()), m.GetA());
        //Debug.Log("Transpuesta: " + tras);

        double aa, bb, cc, dd;

        aa = m.GetD();
        bb = -(m.GetB());
        cc = -(m.GetC());
        dd = m.GetA();

        /*double a4 = aa * dd;
        double b4 = cc * bb;

        double res2 = a4 - b4;*/

        if (det == 0.0)
            return null;

        Matriz2x2 Inv = new Matriz2x2(aa/ det, bb / det, cc / det, dd/ det);

        return Inv;

        

    }

    /**
     * Calcula la <em>n</em>-ésima potencia de la matriz de 2×2.
     *
     * La <em>n</em>-ésima potencia de una matriz de 2×2 es el resultado de
     * multiplicar la matriz consigo misma <em>n</em> veces.
     * @param n La potencia a la que hay que elevar la matriz; si <em>n</em> es
     *          menor que 2, regresa una copia de la matriz de 2×2.
     * @return la <em>n</em>-ésima potencia de la matriz de 2×2.
     */
    public Matriz2x2 Potencia(int n)
        {
            Matriz2x2 m = new Matriz2x2(a, b, c, d);
            if (n < 2)
                return m;
            while (n > 1)
            {
                m = m.Multiplica(this);
                n--;
            }
            return m;
        }

    /**
     * Nos dice si el objeto recibido es una matrix de 2×2 igual a
     * la que manda llamar al método.
     * @param o el objeto con el que se comparará el que manda llamar el método.
     * @return <tt>true</tt> si el objeto o es una matrix de 2×2 igual a la que
     *         manda llamar al método; <tt>false</tt> en otro caso.
     */
    public override bool Equals(System.Object o)
    {
        if (o == null)
            return false;
        if (!(o.GetType() == typeof(Matriz2x2)))
            return false;
        Matriz2x2 m = (Matriz2x2)o;

        if (a == m.GetA() && b == m.GetB() && c == m.GetC() && d == m.GetD())
        {
            return (true);
        }

        else
            return (false);


        // Aquí va su código.
    }

        /**
         * Regresa una representación en cadena de la matriz de 2×2. La
         * representación es de la forma:
<pre>
     ⎛ a  b ⎞
     ⎝ c  d ⎠
</pre>
         * @return una representación en cadena de la matriz de 2×2.
         */
        public override string ToString()
        {
            string sa = a.ToString();
            string sb = b.ToString();
            string sc = c.ToString();
            string sd = d.ToString();

            return "( " + sa + "   " + sb + " )\n" +
                "( " + sc + "   " + sd + " )";
        }
    }

