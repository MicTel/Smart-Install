
#include "userMenu.h"
//#include "stdafx.h"

using namespace SmartInstall;

//[STAThread]

[STAThreadAttribute]
int main(array<System::String ^> ^args)
{
  Application::EnableVisualStyles();
  Application::SetCompatibleTextRenderingDefault(false); 
  Application::Run(gcnew userMenu());
 /*
  userMenu^ WindowUser=gcnew userMenu();
  WindowUser->ShowDialog();*/
  return 0;

}