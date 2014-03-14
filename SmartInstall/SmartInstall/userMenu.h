#pragma once
#include "userMenuListProgram.h"

namespace SmartInstall {
	
	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;
	using namespace System::IO;


	/// <summary>

	/// Summary for userMenu
	/// </summary>
	public ref class userMenu : public System::Windows::Forms::Form
	{
	public:
		userMenu(void)
		{
			InitializeComponent();
			//
			//TODO: Add the constructor code here
			//
		}

	protected:
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		~userMenu()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::MenuStrip^  menuStrip1;
	protected: 
	private: System::Windows::Forms::ToolStripMenuItem^  plikToolStripMenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^  stw�rzArchiwumToolStripMenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^  otw�rzToolStripMenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^  zPlikuToolStripMenuItem;

	private: System::Windows::Forms::ToolStripMenuItem^  usu�ToolStripMenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^  ostatnioU�ywaneToolStripMenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^  zamknijToolStripMenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^  edycjaToolStripMenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^  filtrujWgToolStripMenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^  nazwyToolStripMenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^  grupyToolStripMenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^  datyUtworzeniaToolStripMenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^  datyModyfikacjiToolStripMenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^  widokToolStripMenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^  kategorieToolStripMenuItem1;
	private: System::Windows::Forms::ToolStripMenuItem^  ustawieniaToolStripMenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^  sk�rkiToolStripMenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^  czcionkiToolStripMenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^  ustawieniaToolStripMenuItem1;
	private: System::Windows::Forms::ToolStripMenuItem^  programToolStripMenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^  pomocToolStripMenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^  oAutorachToolStripMenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^  onlineToolStripMenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^  oknoToolStripMenuItem;


	private: System::Windows::Forms::ToolStripMenuItem^  zamknijProgramToolStripMenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^  j�zykToolStripMenuItem;
	private: System::Windows::Forms::CheckedListBox^  checkedListBox1;
	private: System::Windows::Forms::ToolStripMenuItem^  nowaKategoriaToolStripMenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^  usu�KategorieToolStripMenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^  usu�ToolStripMenuItem1;
	private: System::Windows::Forms::Button^  ctrBTOpen;





	private:
		/// <summary>
		/// Required designer variable.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		void InitializeComponent(void)
		{
			this->menuStrip1 = (gcnew System::Windows::Forms::MenuStrip());
			this->plikToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->stw�rzArchiwumToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->otw�rzToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->zPlikuToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->usu�ToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->zamknijToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->ostatnioU�ywaneToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->zamknijProgramToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->edycjaToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->filtrujWgToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->nazwyToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->grupyToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->datyUtworzeniaToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->datyModyfikacjiToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->widokToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->kategorieToolStripMenuItem1 = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->nowaKategoriaToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->usu�KategorieToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->usu�ToolStripMenuItem1 = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->ustawieniaToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->sk�rkiToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->czcionkiToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->j�zykToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->ustawieniaToolStripMenuItem1 = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->oknoToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->programToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->pomocToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->oAutorachToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->onlineToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->checkedListBox1 = (gcnew System::Windows::Forms::CheckedListBox());
			this->ctrBTOpen = (gcnew System::Windows::Forms::Button());
			this->menuStrip1->SuspendLayout();
			this->SuspendLayout();
			// 
			// menuStrip1
			// 
			this->menuStrip1->Items->AddRange(gcnew cli::array< System::Windows::Forms::ToolStripItem^  >(6) {this->plikToolStripMenuItem, 
				this->edycjaToolStripMenuItem, this->widokToolStripMenuItem, this->ustawieniaToolStripMenuItem, this->oknoToolStripMenuItem, 
				this->programToolStripMenuItem});
			this->menuStrip1->Location = System::Drawing::Point(0, 0);
			this->menuStrip1->Name = L"menuStrip1";
			this->menuStrip1->Size = System::Drawing::Size(611, 24);
			this->menuStrip1->TabIndex = 0;
			this->menuStrip1->Text = L"menuStrip1";
			this->menuStrip1->ItemClicked += gcnew System::Windows::Forms::ToolStripItemClickedEventHandler(this, &userMenu::menuStrip1_ItemClicked);
			// 
			// plikToolStripMenuItem
			// 
			this->plikToolStripMenuItem->DropDownItems->AddRange(gcnew cli::array< System::Windows::Forms::ToolStripItem^  >(6) {this->stw�rzArchiwumToolStripMenuItem, 
				this->otw�rzToolStripMenuItem, this->usu�ToolStripMenuItem, this->zamknijToolStripMenuItem, this->ostatnioU�ywaneToolStripMenuItem, 
				this->zamknijProgramToolStripMenuItem});
			this->plikToolStripMenuItem->Name = L"plikToolStripMenuItem";
			this->plikToolStripMenuItem->Size = System::Drawing::Size(38, 20);
			this->plikToolStripMenuItem->Text = L"Plik";
			// 
			// stw�rzArchiwumToolStripMenuItem
			// 
			this->stw�rzArchiwumToolStripMenuItem->Name = L"stw�rzArchiwumToolStripMenuItem";
			this->stw�rzArchiwumToolStripMenuItem->Size = System::Drawing::Size(173, 22);
			this->stw�rzArchiwumToolStripMenuItem->Text = L"Nowe archiwum";
			this->stw�rzArchiwumToolStripMenuItem->Click += gcnew System::EventHandler(this, &userMenu::stw�rzArchiwumToolStripMenuItem_Click);
			// 
			// otw�rzToolStripMenuItem
			// 
			this->otw�rzToolStripMenuItem->DropDownItems->AddRange(gcnew cli::array< System::Windows::Forms::ToolStripItem^  >(1) {this->zPlikuToolStripMenuItem});
			this->otw�rzToolStripMenuItem->Name = L"otw�rzToolStripMenuItem";
			this->otw�rzToolStripMenuItem->Size = System::Drawing::Size(173, 22);
			this->otw�rzToolStripMenuItem->Text = L"Dodaj achiwum";
			// 
			// zPlikuToolStripMenuItem
			// 
			this->zPlikuToolStripMenuItem->Name = L"zPlikuToolStripMenuItem";
			this->zPlikuToolStripMenuItem->Size = System::Drawing::Size(116, 22);
			this->zPlikuToolStripMenuItem->Text = L"Z pliku..";
			this->zPlikuToolStripMenuItem->Click += gcnew System::EventHandler(this, &userMenu::zPlikuToolStripMenuItem_Click);
			// 
			// usu�ToolStripMenuItem
			// 
			this->usu�ToolStripMenuItem->Name = L"usu�ToolStripMenuItem";
			this->usu�ToolStripMenuItem->Size = System::Drawing::Size(173, 22);
			this->usu�ToolStripMenuItem->Text = L"Usu�";
			// 
			// zamknijToolStripMenuItem
			// 
			this->zamknijToolStripMenuItem->Name = L"zamknijToolStripMenuItem";
			this->zamknijToolStripMenuItem->Size = System::Drawing::Size(173, 22);
			this->zamknijToolStripMenuItem->Text = L"Zamknij archiwum";
			// 
			// ostatnioU�ywaneToolStripMenuItem
			// 
			this->ostatnioU�ywaneToolStripMenuItem->Name = L"ostatnioU�ywaneToolStripMenuItem";
			this->ostatnioU�ywaneToolStripMenuItem->Size = System::Drawing::Size(173, 22);
			this->ostatnioU�ywaneToolStripMenuItem->Text = L"Ostatnio u�ywane";
			// 
			// zamknijProgramToolStripMenuItem
			// 
			this->zamknijProgramToolStripMenuItem->Name = L"zamknijProgramToolStripMenuItem";
			this->zamknijProgramToolStripMenuItem->Size = System::Drawing::Size(173, 22);
			this->zamknijProgramToolStripMenuItem->Text = L"Zamknij program";
			// 
			// edycjaToolStripMenuItem
			// 
			this->edycjaToolStripMenuItem->DropDownItems->AddRange(gcnew cli::array< System::Windows::Forms::ToolStripItem^  >(1) {this->filtrujWgToolStripMenuItem});
			this->edycjaToolStripMenuItem->Name = L"edycjaToolStripMenuItem";
			this->edycjaToolStripMenuItem->Size = System::Drawing::Size(53, 20);
			this->edycjaToolStripMenuItem->Text = L"Edycja";
			// 
			// filtrujWgToolStripMenuItem
			// 
			this->filtrujWgToolStripMenuItem->DropDownItems->AddRange(gcnew cli::array< System::Windows::Forms::ToolStripItem^  >(4) {this->nazwyToolStripMenuItem, 
				this->grupyToolStripMenuItem, this->datyUtworzeniaToolStripMenuItem, this->datyModyfikacjiToolStripMenuItem});
			this->filtrujWgToolStripMenuItem->Name = L"filtrujWgToolStripMenuItem";
			this->filtrujWgToolStripMenuItem->Size = System::Drawing::Size(132, 22);
			this->filtrujWgToolStripMenuItem->Text = L"Filtruj wg...";
			// 
			// nazwyToolStripMenuItem
			// 
			this->nazwyToolStripMenuItem->Name = L"nazwyToolStripMenuItem";
			this->nazwyToolStripMenuItem->Size = System::Drawing::Size(162, 22);
			this->nazwyToolStripMenuItem->Text = L"nazwy";
			// 
			// grupyToolStripMenuItem
			// 
			this->grupyToolStripMenuItem->Name = L"grupyToolStripMenuItem";
			this->grupyToolStripMenuItem->Size = System::Drawing::Size(162, 22);
			this->grupyToolStripMenuItem->Text = L"grupy";
			// 
			// datyUtworzeniaToolStripMenuItem
			// 
			this->datyUtworzeniaToolStripMenuItem->Name = L"datyUtworzeniaToolStripMenuItem";
			this->datyUtworzeniaToolStripMenuItem->Size = System::Drawing::Size(162, 22);
			this->datyUtworzeniaToolStripMenuItem->Text = L"daty utworzenia";
			// 
			// datyModyfikacjiToolStripMenuItem
			// 
			this->datyModyfikacjiToolStripMenuItem->Name = L"datyModyfikacjiToolStripMenuItem";
			this->datyModyfikacjiToolStripMenuItem->Size = System::Drawing::Size(162, 22);
			this->datyModyfikacjiToolStripMenuItem->Text = L"daty modyfikacji";
			// 
			// widokToolStripMenuItem
			// 
			this->widokToolStripMenuItem->DropDownItems->AddRange(gcnew cli::array< System::Windows::Forms::ToolStripItem^  >(1) {this->kategorieToolStripMenuItem1});
			this->widokToolStripMenuItem->Name = L"widokToolStripMenuItem";
			this->widokToolStripMenuItem->Size = System::Drawing::Size(53, 20);
			this->widokToolStripMenuItem->Text = L"Widok";
			// 
			// kategorieToolStripMenuItem1
			// 
			this->kategorieToolStripMenuItem1->DropDownItems->AddRange(gcnew cli::array< System::Windows::Forms::ToolStripItem^  >(3) {this->nowaKategoriaToolStripMenuItem, 
				this->usu�KategorieToolStripMenuItem, this->usu�ToolStripMenuItem1});
			this->kategorieToolStripMenuItem1->Name = L"kategorieToolStripMenuItem1";
			this->kategorieToolStripMenuItem1->Size = System::Drawing::Size(124, 22);
			this->kategorieToolStripMenuItem1->Text = L"Kategorie";
			// 
			// nowaKategoriaToolStripMenuItem
			// 
			this->nowaKategoriaToolStripMenuItem->Name = L"nowaKategoriaToolStripMenuItem";
			this->nowaKategoriaToolStripMenuItem->Size = System::Drawing::Size(107, 22);
			this->nowaKategoriaToolStripMenuItem->Text = L"Nowa";
			// 
			// usu�KategorieToolStripMenuItem
			// 
			this->usu�KategorieToolStripMenuItem->Name = L"usu�KategorieToolStripMenuItem";
			this->usu�KategorieToolStripMenuItem->Size = System::Drawing::Size(107, 22);
			this->usu�KategorieToolStripMenuItem->Text = L"Edytuj";
			// 
			// usu�ToolStripMenuItem1
			// 
			this->usu�ToolStripMenuItem1->Name = L"usu�ToolStripMenuItem1";
			this->usu�ToolStripMenuItem1->Size = System::Drawing::Size(107, 22);
			this->usu�ToolStripMenuItem1->Text = L"Usu�";
			// 
			// ustawieniaToolStripMenuItem
			// 
			this->ustawieniaToolStripMenuItem->DropDownItems->AddRange(gcnew cli::array< System::Windows::Forms::ToolStripItem^  >(4) {this->sk�rkiToolStripMenuItem, 
				this->czcionkiToolStripMenuItem, this->j�zykToolStripMenuItem, this->ustawieniaToolStripMenuItem1});
			this->ustawieniaToolStripMenuItem->Name = L"ustawieniaToolStripMenuItem";
			this->ustawieniaToolStripMenuItem->Size = System::Drawing::Size(76, 20);
			this->ustawieniaToolStripMenuItem->Text = L"Ustawienia";
			// 
			// sk�rkiToolStripMenuItem
			// 
			this->sk�rkiToolStripMenuItem->Name = L"sk�rkiToolStripMenuItem";
			this->sk�rkiToolStripMenuItem->Size = System::Drawing::Size(131, 22);
			this->sk�rkiToolStripMenuItem->Text = L"Sk�rki";
			// 
			// czcionkiToolStripMenuItem
			// 
			this->czcionkiToolStripMenuItem->Name = L"czcionkiToolStripMenuItem";
			this->czcionkiToolStripMenuItem->Size = System::Drawing::Size(131, 22);
			this->czcionkiToolStripMenuItem->Text = L"Czcionki";
			// 
			// j�zykToolStripMenuItem
			// 
			this->j�zykToolStripMenuItem->Name = L"j�zykToolStripMenuItem";
			this->j�zykToolStripMenuItem->Size = System::Drawing::Size(131, 22);
			this->j�zykToolStripMenuItem->Text = L"J�zyk";
			// 
			// ustawieniaToolStripMenuItem1
			// 
			this->ustawieniaToolStripMenuItem1->Name = L"ustawieniaToolStripMenuItem1";
			this->ustawieniaToolStripMenuItem1->Size = System::Drawing::Size(131, 22);
			this->ustawieniaToolStripMenuItem1->Text = L"Ustawienia";
			// 
			// oknoToolStripMenuItem
			// 
			this->oknoToolStripMenuItem->Name = L"oknoToolStripMenuItem";
			this->oknoToolStripMenuItem->Size = System::Drawing::Size(48, 20);
			this->oknoToolStripMenuItem->Text = L"Okno";
			// 
			// programToolStripMenuItem
			// 
			this->programToolStripMenuItem->DropDownItems->AddRange(gcnew cli::array< System::Windows::Forms::ToolStripItem^  >(3) {this->pomocToolStripMenuItem, 
				this->oAutorachToolStripMenuItem, this->onlineToolStripMenuItem});
			this->programToolStripMenuItem->Name = L"programToolStripMenuItem";
			this->programToolStripMenuItem->Size = System::Drawing::Size(57, 20);
			this->programToolStripMenuItem->Text = L"Pomoc";
			this->programToolStripMenuItem->Click += gcnew System::EventHandler(this, &userMenu::programToolStripMenuItem_Click);
			// 
			// pomocToolStripMenuItem
			// 
			this->pomocToolStripMenuItem->Name = L"pomocToolStripMenuItem";
			this->pomocToolStripMenuItem->Size = System::Drawing::Size(200, 22);
			this->pomocToolStripMenuItem->Text = L"Pomoc";
			// 
			// oAutorachToolStripMenuItem
			// 
			this->oAutorachToolStripMenuItem->Name = L"oAutorachToolStripMenuItem";
			this->oAutorachToolStripMenuItem->Size = System::Drawing::Size(200, 22);
			this->oAutorachToolStripMenuItem->Text = L"O autorach";
			// 
			// onlineToolStripMenuItem
			// 
			this->onlineToolStripMenuItem->Name = L"onlineToolStripMenuItem";
			this->onlineToolStripMenuItem->Size = System::Drawing::Size(200, 22);
			this->onlineToolStripMenuItem->Text = L"Strona programu online";
			// 
			// checkedListBox1
			// 
			this->checkedListBox1->FormattingEnabled = true;
			this->checkedListBox1->Items->AddRange(gcnew cli::array< System::Object^  >(9) {L"System", L"Sterowniki", L"Zarz�dzanie dyskiem", 
				L"Odtwarzacze ", L"Muzyka", L"Grafika", L"Kompilatory", L"Edytory tekstu", L"Edukacja"});
			this->checkedListBox1->Location = System::Drawing::Point(27, 44);
			this->checkedListBox1->Name = L"checkedListBox1";
			this->checkedListBox1->Size = System::Drawing::Size(269, 229);
			this->checkedListBox1->TabIndex = 10;
			this->checkedListBox1->SelectedIndexChanged += gcnew System::EventHandler(this, &userMenu::checkedListBox1_SelectedIndexChanged);
			// 
			// ctrBTOpen
			// 
			this->ctrBTOpen->Location = System::Drawing::Point(349, 218);
			this->ctrBTOpen->Name = L"ctrBTOpen";
			this->ctrBTOpen->Size = System::Drawing::Size(117, 55);
			this->ctrBTOpen->TabIndex = 11;
			this->ctrBTOpen->Text = L"Uruchom";
			this->ctrBTOpen->UseVisualStyleBackColor = true;
			this->ctrBTOpen->Click += gcnew System::EventHandler(this, &userMenu::ctrBTOpen_Click);
			// 
			// userMenu
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(611, 286);
			this->Controls->Add(this->ctrBTOpen);
			this->Controls->Add(this->checkedListBox1);
			this->Controls->Add(this->menuStrip1);
			this->MainMenuStrip = this->menuStrip1;
			this->Name = L"userMenu";
			this->Text = L"userMenu";
			this->Load += gcnew System::EventHandler(this, &userMenu::userMenu_Load);
			this->menuStrip1->ResumeLayout(false);
			this->menuStrip1->PerformLayout();
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
private: System::Void programToolStripMenuItem_Click(System::Object^  sender, System::EventArgs^  e) 
		 {
		 }

private: System::Void userMenu_Load(System::Object^  sender, System::EventArgs^  e) 
		 {
		 }
private: System::Void folderBrowserDialog1_HelpRequest(System::Object^  sender, System::EventArgs^  e) 
		 {
		 }
private: System::Void checkedListBox1_SelectedIndexChanged(System::Object^  sender, System::EventArgs^  e) 
		 {
		 }
private: System::Void menuStrip1_ItemClicked(System::Object^  sender, System::Windows::Forms::ToolStripItemClickedEventArgs^  e) 
		 {
		 }

private: System::Void ctrBTOpen_Click(System::Object^  sender, System::EventArgs^  e) 
		 {
			 userMenuListProgram^ WindowUser=gcnew userMenuListProgram();
			 WindowUser->ShowDialog();
				 
		 }
private: System::Void zPlikuToolStripMenuItem_Click(System::Object^  sender, System::EventArgs^  e) 
		 {
			 Stream^ myStream;
			 OpenFileDialog^ openFileDialog1 = gcnew OpenFileDialog;
			 if ( openFileDialog1->ShowDialog() == System::Windows::Forms::DialogResult::OK )
			{
				if ( (myStream = openFileDialog1->OpenFile()) != nullptr )
					{
					// Insert code to read the stream here.
					myStream->Close();
					}
			}

		 }
private: System::Void stw�rzArchiwumToolStripMenuItem_Click(System::Object^  sender, System::EventArgs^  e) 
		 {
			 Stream^ myStream;
			 OpenFileDialog^ openFileDialog1 = gcnew OpenFileDialog;
			 if ( openFileDialog1->ShowDialog() == System::Windows::Forms::DialogResult::OK )
			{
				if ( (myStream = openFileDialog1->OpenFile()) != nullptr )
					{
					// Insert code to read the stream here.
					myStream->Close();
					}
			}

		 }
};
}
