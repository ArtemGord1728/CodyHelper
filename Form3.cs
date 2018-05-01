using System;
using System.Windows.Forms;
using Microsoft.Speech.Recognition;
using System.Reflection;
using System.Diagnostics;
using Microsoft.Win32;
using System.Globalization;



/*******************************************************************/

/* Original File Name: Form3.cs                                    */

/* Date: 01-05-2018                                                */

/* Developer: ArtemGord1728                                        */

/* Copyright © 2018 ArtemGord1728. All rights reserved             */

/* Description: The basic functionality of voice control           */

/*******************************************************************/


namespace CodyHelper
{
    public partial class Form3 : Form
    {
        public CultureInfo ci;
        private SpeechRecognitionEngine engine;

        public Form3()
        {
            InitializeComponent();
        }



        private void Engine_RecognizeCompleted(object sender, RecognizeCompletedEventArgs e)
        {
            AddLine("RecognizeCompleted" + e.Result.Text);
        }


        private void Engine_SpeechRecognitionRejected(object sender, SpeechRecognitionRejectedEventArgs e)
        {
            AddLine("SpeechRecognitionRejected" + e.Result.Text + "(" + e.Result.Confidence + ")");
        }

        private void Engine_SpeechHypothesized(object sender, SpeechHypothesizedEventArgs e)
        {
            AddLine("SpeechHypothesized" + e.Result.Text);
        }

        private void Engine_SpeechDetected(object sender, SpeechDetectedEventArgs e)
        {
            AddLine("SpeechDetected audio pos: " + e.AudioPosition);
        }

        private void Engine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            AddLine("\t" + "SpeechRecognized");

            AddLine(e.Result.Text + " (" + e.Result.Confidence + ")");

            if (e.Result.Confidence < 0.1f)
                return;

            foreach (var s in e.Result.Semantics)
            {
                var program = (string)s.Value.Value;

                switch (s.Key)
                {
                    case "start":
                        Process.Start(program);
                        break;
                    case "close":
                        var p = Process.GetProcessesByName(program);
                        if (p.Length > 0)
                            p[0].Kill();
                        break;
                }
            }
        }

        // No useful function
        private void AddLine(string v)
        {

        }


        //Autorun Flag
        public bool GetToAutorun(bool run,string path)
        {
            string filePath = path;
            RegistryKey rg;
            rg = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run");
            return true;
        }

        #region Grammar Builder 
        private Choices VoiceController()
        {
            var com1 = new SemanticResultValue("калькулятор", "calc");
            var com2 = new SemanticResultValue("Вижуал Студио", @"D:\Microsoft Visual Studio 2017\Common7\IDE\devenv.exe");
            var com3 = new SemanticResultValue("Гугл", @"C:\Program Files (x86)\Google\Chrome\chrome.exe");
            var com4 = new SemanticResultValue("Телеграмм", @"D:\Telegram Desktop\Telegram.exe");
            var com5 = new SemanticResultValue("диспетчер задач", "Taskmgr");
            var com6 = new SemanticResultValue("Кью тэ", @"D:\Qt\Tools\QtCreator\bin\qtcreator.exe");
            var com7 = new SemanticResultValue("юнити", @"D:\Установочные компоненты для Unity\Editor\Unity.exe");
            var com8 = new SemanticResultValue("Андроид Студио", @"D:\Android Studio\bin\studio.exe");
            var com9 = new SemanticResultValue("командную строку","cmd");
            var com10 = new SemanticResultValue("редактор реестра","regedit");

            return new Choices(com1, com2, com3, com4, com5, com6,com7,com8,com9,com10);
        }

        private Grammar OpenGrammar()
        {
            var commands = VoiceController();

            var grammarBuilder = new GrammarBuilder("запустить", SubsetMatchingMode.SubsequenceContentRequired);
            grammarBuilder.Culture = ci;
            grammarBuilder.Append(new SemanticResultKey("start", commands));

            return new Grammar(grammarBuilder);
        }

        private Grammar CloseGrammar()
        {
            var commands = VoiceController();

            var grammarBuilder = new GrammarBuilder("закрыть", SubsetMatchingMode.SubsequenceContentRequired);
            grammarBuilder.Culture = ci;
            grammarBuilder.Append(new SemanticResultKey("close", commands));

            return new Grammar(grammarBuilder);
        }
        #endregion

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            GetToAutorun(true, Assembly.GetExecutingAssembly().Location);

            try
            {
                ci = new CultureInfo("ru-ru");
                engine = new SpeechRecognitionEngine(ci);
                GrammarBuilder CreateSampleGrammer1 = new GrammarBuilder();

                engine.SpeechRecognized += Engine_SpeechRecognized;
                engine.SpeechDetected += Engine_SpeechDetected;
                engine.SpeechHypothesized += Engine_SpeechHypothesized;
                engine.SpeechRecognitionRejected += Engine_SpeechRecognitionRejected;
                engine.RecognizeCompleted += Engine_RecognizeCompleted;

                engine.SetInputToDefaultAudioDevice();

                engine.LoadGrammar(OpenGrammar());
                engine.LoadGrammar(CloseGrammar());

                engine.RecognizeAsync(RecognizeMode.Multiple);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            

            DialogResult dialogResult = MessageBox.Show("Вы уверенны, что хотите выключить данную функцию?" +
                " Выключение функции полностью закроет приложение", "Закрытие приложения", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            switch (dialogResult)
            {
                case DialogResult.OK:
                    Process.GetCurrentProcess().Kill();
                    break;
            }
        }
    }
}
