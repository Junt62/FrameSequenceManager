using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;

namespace FrameSequenceManager {

    public partial class Util {

        public static string GetAfterFXPath(string AEName) {
            try {
                Process[] processes = Process.GetProcessesByName(AEName);
                var proc = processes.FirstOrDefault(x => {
                    try {
                        return string.Equals(
                            Path.GetFileName(x.MainModule?.FileName),
                            AEName + ".exe",
                            StringComparison.OrdinalIgnoreCase
                        );
                    }
                    catch {
                        return false;
                    }
                });
                return proc?.MainModule?.FileName ?? "";
            }
            catch {
                return "";
            }
        }


        public static void ImportFile(string aePath, List<string> path) {
            string exeDir = AppDomain.CurrentDomain.BaseDirectory;
            string jsxPath = Path.Combine(exeDir, "importFile.jsx");

            //string jsx = $@"
            //            var importFile = new File(""{path.Replace(@"\", @"\\")}"");
            //            var importOptions = new ImportOptions(file)
            //            app.project.importFile(new ImportOptions(importFile));
            //        ";
            //File.WriteAllText(jsxPath, jsx);

            try {
                ProcessStartInfo psi = new ProcessStartInfo {
                    FileName = "powershell.exe",
                    Arguments = $"-NoProfile -Command \"& \\\"{aePath}\\\" -r \\\"{jsxPath}\\\"\"",
                    UseShellExecute = false,
                    RedirectStandardError = true,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                };
                Process proc = Process.Start(psi);
            }
            catch(Exception ex) {
                MessageBox.Show("����ʧ�ܣ�" + ex.Message);
            }
        }
    }
}