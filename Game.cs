using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method_Pattern
{
    public class Game
    {
        private Player _player;

        public Game()
        {
            // Начальное оружие — меч
            _player = new Player(new Sword());
        }

        public void Start()
        {
            while (true)
            {
                Console.WriteLine("Выбери оружие: 1 - Sword, 2 - Bow, 3 - Axe, 0 - Выход");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        _player.SetWeapon(new Sword());
                        break;
                    case "2":
                        _player.SetWeapon(new Bow());
                        break;
                    case "3":
                        _player.SetWeapon(new Axe());
                        break;
                    case "0":
                        Console.WriteLine("выйти из игры.");
                        return;
                    default:
                        Console.WriteLine("ошибка набора. попробуйте еще раз.");
                        continue;
                }

                _player.Attack();
            }
        }
    }

}
