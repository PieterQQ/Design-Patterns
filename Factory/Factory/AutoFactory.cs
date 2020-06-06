using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Autos;
using System.Reflection;

namespace Factory
{
    public class AutoFactory
    {
        Dictionary<string, Type> autos;  
        public AutoFactory()
        {
            LoadTypesICanReturn();
        }
        public IAuto GetAuto(string carName)
        {
            Type t = GetTypeToCreate(carName);
            if (t == null)
                return new NullCar();
            else
                return Activator.CreateInstance(t) as IAuto;
        }
        Type GetTypeToCreate(string carName)
        {
            foreach (var auto in autos)
            {
                if (auto.Key.Contains(carName))
                {
                    return autos[auto.Key];
                }
              
            }
            return null;
        }
        private void LoadTypesICanReturn()
        {
            autos = new Dictionary<string, Type>();
            Type[] typeInThisAssembly = Assembly.GetExecutingAssembly().GetTypes();

            foreach (Type type in typeInThisAssembly)
            {
                if(type.GetInterface(typeof(IAuto).ToString())!=null)
                    autos.Add(type.Name.ToLower(), type);
                
 
                        }
        }
    }
}
