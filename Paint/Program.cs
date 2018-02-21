
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Windows.Forms;
/*
-  dynamicznie ładowane wtyczki (mechanizm Refleksji) powinny integrować
  się z GUI aplikacji (menu, toolbary, okno opcji) i wykonywać operacje
  na całym obrazie (np. transformacje, konwersje kolorów)

- operacje długotrwałe (np. na całym obrazie) powinny być realizowane
  w osobnych wątkach, aby nie powodowały zakłóceń w funkcjonowaniu
  interfejsu użytkownika

- aplikacja powinna obsługiwać mechanizm undo/redo pozwalający na
  cofanie/ponawianie ostatnio wykonanych operacji (z uwzględnieniem
  operacji wykonywanych przez wtyczki) 
 */
namespace Paint
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PaintForm());
        }
    }
}