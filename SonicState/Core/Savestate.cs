using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace SonicState
{
    public abstract class Savestate
    {
        protected bool loaded = false;
        protected byte[] savestateData;

        public void Load(string path)
        {
            savestateData = File.ReadAllBytes(path);

            PropertyInfo[] properties = this.GetType().GetProperties();
            foreach (PropertyInfo property in properties)
            {
                object value = property.GetValue(this, null);

                object[] attributes = property.GetCustomAttributes(typeof(SavestateVariable), false);
                if (attributes.Length == 0) continue;

                SavestateVariable variable = (SavestateVariable)attributes[0];
                
                if (value is byte ||
                    value is Sonic1Zone ||
                    value is Sonic2Zone ||
                    value is Sonic3Zone ||
                    value is Sonic1MasterTrigger ||
                    value is Sonic2MasterTrigger ||
                    value is Sonic3MasterTrigger)
                {
                    byte setValue = savestateData[variable.Address];
                    property.SetValue(this, setValue, null);
                }
                else if (value is Int16 ||
                    value is Sonic2PlayerInGame ||
                    value is Sonic3PlayerInGame)
                {
                    Int16 setValue = savestateData[variable.Address];
                    setValue <<= 8;
                    setValue += savestateData[variable.Address + 1];

                    property.SetValue(this, setValue, null);
                }
                else if (value is uint)
                {
                    uint setValue = savestateData[variable.Address];
                    setValue <<= 8;
                    setValue += savestateData[variable.Address + 1];
                    setValue <<= 8;
                    setValue += savestateData[variable.Address + 2];
                    setValue <<= 8;
                    setValue += savestateData[variable.Address + 3];

                    property.SetValue(this, setValue, null);
                }
                else if (value is bool)
                {
                    bool setValue = (savestateData[variable.Address] > 0 ? true : false);
                    property.SetValue(this, setValue, null);
                }
            }

            loaded = true;
        }

        public void Save(string path)
        {
            if (!loaded) throw new Exception("A savestate cannot be saved without first being loaded.");
            
            PropertyInfo[] properties = this.GetType().GetProperties();
            foreach (PropertyInfo property in properties)
            {
                object value = property.GetValue(this, null);
                
                object[] attributes = property.GetCustomAttributes(typeof(SavestateVariable), false);
                if (attributes.Length == 0) continue;
                
                SavestateVariable variable = (SavestateVariable)attributes[0];

                if (value is byte ||
                    value is Sonic1Zone ||
                    value is Sonic2Zone ||
                    value is Sonic3Zone ||
                    value is Sonic1MasterTrigger ||
                    value is Sonic2MasterTrigger ||
                    value is Sonic3MasterTrigger)
                {
                    savestateData[variable.Address] = (byte)value;
                }
                else if (value is Int16 ||
                    value is Sonic2PlayerInGame ||
                    value is Sonic3PlayerInGame)
                {
                    byte[] bytes = BitConverter.GetBytes((Int16)value);
                    Array.Reverse(bytes);
                    for (int c = 0; c < bytes.Length; c++)
                        savestateData[variable.Address + c] = bytes[c];
                }
                else if (value is uint)
                {
                    byte[] bytes = BitConverter.GetBytes((uint)value);
                    Array.Reverse(bytes);
                    for (int c = 0; c < bytes.Length; c++)
                        savestateData[variable.Address + c] = bytes[c];
                }
                else if (value is bool)
                {
                    savestateData[variable.Address] = (byte)((bool)value ? 1 : 0);
                }
            }

            using (FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Write))
            {
                stream.Write(savestateData, 0, savestateData.Length);
            }
        }

        public void CopyRange(string filename, int start, int end)
        {

        }
    }
}
