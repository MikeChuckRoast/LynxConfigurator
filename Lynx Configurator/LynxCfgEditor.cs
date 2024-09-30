using System.Text;

namespace Lynx_Configurator
{
    internal class LynxCfgEditor
    {
        private string _cfgPath;
        private List<string> _lines = new List<string>();

        public LynxCfgEditor(string cfgPath)
        { 
            this._cfgPath = cfgPath;
            if (!System.IO.File.Exists(cfgPath))
            {
                throw new System.IO.FileNotFoundException("The specified file does not exist.", cfgPath);
            }
            Load();
        }

        public void Load()
        {
            _lines = new List<string>(File.ReadAllLines(_cfgPath));
        }

        public void Save()
        {
            File.WriteAllLines(_cfgPath, _lines, Encoding.Unicode);
        }

        public void Set(string key, string value)
        {
            for (int i = 0; i < _lines.Count; i++)
            {
                if (_lines[i].StartsWith(key + ":"))
                {
                    string[] values = _lines[i].Split('=');
                    if ( values.Length != 2)
                    {
                        throw new Exception("Line did not have =");
                    }
                    _lines[i] = values[0] + "=" + value;
                    return;
                }
            }
            throw new Exception("Line not found");
        }

        public string? Get(string key)
        {
            for (int i = 0; i < _lines.Count; i++)
            {
                if (_lines[i].StartsWith(key + ":"))
                {
                    string[] values = _lines[i].Split('=');
                    if (values.Length != 2)
                    {
                        return null;
                    }
                    return values[1];
                }
            }
            return null;
        }

        public string getEventDirectory()
        {
            return Get("\\Event\\Directory") ?? "";
        }

        public void setEventDirectory(string value)
        {
            Set("\\Event\\Directory", value);
        }

        public string getDatabaseFileDataInDir()
        {
            return Get("\\Database\\File\\DataInDir") ?? "";
        }

        public void setDatabaseFileDataInDir(string value)
        {
            Set("\\Database\\File\\DataInDir", value);
        }

        public string getDatabaseFileDataOutDir()
        {
            return Get("\\Database\\File\\DataOutDir") ?? "";
        }

        public void setDatabaseFileDataOutDir(string value)
        {
            Set("\\Database\\File\\DataOutDir", value);
        }

        public string getEventBackupDir()
        {
            return Get("\\Event\\BackupDir") ?? "";
        }

        public void setEventBackupDir(string value)
        {
            Set("\\Event\\BackupDir", value);
        }

        public int getDatabaseLIFAutoSave()
        {
            return int.Parse(Get("\\Database\\LIF\\AutoSave") ?? "0");
        }

        public void setDatabaseLIFAutoSave(int value)
        {
            Set("\\Database\\LIF\\AutoSave", value.ToString());
        }

        public string getEventImageOverlayLinesFormat()
        {
            return Get("\\Event\\Image\\Overlay\\Lines\\Format") ?? "";
        }

        public void setEventImageOverlayLinesFormat(string value)
        {
            Set("\\Event\\Image\\Overlay\\Lines\\Format", value);
        }

        public string getEventImageOverlayIdLLinesFormat()
        {
            return Get("\\Event\\Image\\Overlay\\IdLLines\\Format") ?? "";
        }

        public void setEventImageOverlayIdLLinesFormat(string value)
        {
            Set("\\Event\\Image\\Overlay\\IdLLines\\Format", value);
        }

        public bool getLapTimeCreateResults()
        {
            return Get("\\LapTime\\CreateResults") == "1";
        }

        public void setLapTimeCreateResults(bool value)
        {
            Set("\\LapTime\\CreateResults", value ? "1" : "0");
        }

        public bool getLapTimeFillInTime()
        {
            return Get("\\LapTime\\FillInTime") == "2";
        }

        public void setLapTimeFillInTime(bool value)
        {
            Set("\\LapTime\\FillInTime", value ? "2" : "1");
        }

        public int getLapTimeTotalLaps()
        {
            return int.Parse(Get("\\LapTime\\TotalLaps") ?? "0");
        }

        public void setLapTimeTotalLaps(int value)
        {
            Set("\\LapTime\\TotalLaps", value.ToString());
        }

        public int getLapTimeStartMask()
        {
            return int.Parse(Get("\\LapTime\\StartMask") ?? "0") / 1000;
        }

        public void setLapTimeStartMask(int value)
        {
            Set("\\LapTime\\StartMask", (value * 1000).ToString());
        }

        public int getLapTimeDuplicateMask()
        {
            return int.Parse(Get("\\LapTime\\DuplicateMask") ?? "0") / 1000;
        }

        public void setLapTimeDuplicateMask(int value)
        {
            Set("\\LapTime\\DuplicateMask", (value * 1000).ToString());
        }
    }
}
