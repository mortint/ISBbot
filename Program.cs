using ISP.Forms;
using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

[assembly: Obfuscation(Exclude = false, Feature = "namespace('ISP.Forms'):-rename")]
[assembly: Obfuscation(Exclude = false, Feature = "namespace('ISP.Configs'):-rename")]
[assembly: Obfuscation(Exclude = false, Feature = "namespace('ISP.Tasks'):-rename")]
[assembly: Obfuscation(Exclude = false, Feature = "namespace('ISP.Engine'):-rename")]

namespace ISP {
    internal static class Program {
        [STAThread]
        private static void Main(){
            AppDomain.CurrentDomain.AssemblyResolve += AbsenceOfDLL;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var instance = Assembly.GetExecutingAssembly().CreateInstance(
                "ISP.Forms.MainForm") as MainForm;

            Application.Run(instance);
        }

        private static Assembly AbsenceOfDLL(object sender, ResolveEventArgs args) {
            var folderPath = @"DLL";
            var assemblyPath = Path.Combine(folderPath, new AssemblyName(args.Name).Name + ".dll");

            if (File.Exists(assemblyPath)) {
                return Assembly.LoadFrom(assemblyPath);
            }

            return null;
        }
    }
}