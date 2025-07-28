using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1
{
    public class GameManager : MonoBehaviour
    {
        private GameManager() 
        {
        Run();
        } 
        static private GameManager instancia;
        static public GameManager Instancia => instancia ??= new GameManager(); 
        
        public Mapa mapa;
        public Menu menu;
        public Jardim jardim;

        public override void Update()
        {
            Console.Clear();
            Draw();
            var tecla = Console.ReadKey(true).Key;
            Jardim.Instancia.AtualizarPosicao(tecla);
        }

        public override void Draw()
        {
            if (menu != null && menu.visible) menu.Draw();
            if (mapa != null && mapa.visible) mapa.Draw();
            if (jardim != null && jardim.visible) jardim.Draw();

        }

        public override void Start()
        {

            menu = Menu.Instancia;
            menu.visible = true;
            menu.input = true;

        }


    }
}
