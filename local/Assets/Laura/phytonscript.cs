using UnityEngine;
using System.Diagnostics;

public class phytonscript : MonoBehaviour
{
    private void Start()
    {
        StartWebcamStream();
    }

    private void StartWebcamStream()
    {
        string pythonScriptPath = "C:\\Users\\ecl\\Desktop\\Laura\\python script camera";  // actual path
        string pythonInterpreter = "python";  // Update if necessary

        ProcessStartInfo psi = new ProcessStartInfo(pythonInterpreter);
        psi.Arguments = pythonScriptPath;

        Process process = new Process();
        process.StartInfo = psi;
        process.Start();

    }
}
