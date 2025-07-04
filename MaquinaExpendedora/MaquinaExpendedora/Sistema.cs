using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaExpendedora
{
    public class Sistema
    {

        private Dictionary<string, Stack<Producto>> matriz;
        public Sistema() 
        {
            matriz = new Dictionary<string, Stack<Producto>>();

            matriz["00"] = new Stack<Producto>();
            for (int i = 0; i < 5; i++) matriz["00"].Push(new Producto("Tronaditas", 300, 1));

            matriz["01"] = new Stack<Producto>();
            for (int i = 0; i < 5; i++) matriz["01"].Push(new Producto("Doritos", 350, 1));

            matriz["02"] = new Stack<Producto>();
            for (int i = 0; i < 5; i++) matriz["02"].Push(new Producto("Lays", 350, 1));


            matriz["10"] = new Stack<Producto>();
            for (int i = 0; i < 5; i++) matriz["10"].Push(new Producto("Kitkat", 250, 1));

            matriz["11"] = new Stack<Producto>();
            for (int i = 0; i < 5; i++) matriz["11"].Push(new Producto("Pringles", 400, 1));

            matriz["12"] = new Stack<Producto>();
            for (int i = 0; i < 5; i++) matriz["12"].Push(new Producto("Chiky", 375, 1));


            matriz["20"] = new Stack<Producto>();
            for (int i = 0; i < 5; i++) matriz["20"].Push(new Producto("Skittles", 300, 1));

            matriz["21"] = new Stack<Producto>();
            for (int i = 0; i < 5; i++) matriz["21"].Push(new Producto("Agua Botella", 500, 1));

            matriz["22"] = new Stack<Producto>();
            for (int i = 0; i < 5; i++) matriz["22"].Push(new Producto("Oreo", 300, 1));


            matriz["30"] = new Stack<Producto>();
            for (int i = 0; i < 5; i++) matriz["30"].Push(new Producto("Té frío", 450, 1));

            matriz["31"] = new Stack<Producto>();
            for (int i = 0; i < 5; i++) matriz["31"].Push(new Producto("Coca-Cola", 500, 1));

            matriz["32"] = new Stack<Producto>();
            for (int i = 0; i < 5; i++) matriz["32"].Push(new Producto("Cola-dieta", 500, 1));


            matriz["40"] = new Stack<Producto>();
            for (int i = 0; i < 5; i++) matriz["40"].Push(new Producto("Redbull", 600, 1));

            matriz["41"] = new Stack<Producto>();
            for (int i = 0; i < 5; i++) matriz["41"].Push(new Producto("Rompope", 300, 1));

            matriz["42"] = new Stack<Producto>();
            for (int i = 0; i < 5; i++) matriz["42"].Push(new Producto("Fresca", 500, 1));


        }


        public Stack<Producto> ObtenerPila(string codigo)//busca una pila de productos por su código.
        {
            if (matriz.ContainsKey(codigo))
                return matriz[codigo];
            else
                return new Stack<Producto>();
        }

        public Dictionary<string, Stack<Producto>> ObtenerPilas()//devuelve el diccionario
        {
            return matriz;
        }
        public bool ExisteCodigo(string codigo)//si un codigo existe
        {
            return matriz.ContainsKey(codigo);
        }




    }
}
