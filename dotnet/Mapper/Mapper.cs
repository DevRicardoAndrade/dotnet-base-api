namespace dotnet.Mapper
{
    public static class Mapper
    {
        public static TTo Map<TBase, TTo>(TBase objBase, TTo objTo)
        {
            Type baseType = typeof(TBase);
            Type toType = typeof(TTo);  

            foreach (var baseProp in baseType.GetProperties())
            {
                foreach (var toProp in toType.GetProperties())
                {
                    if(baseProp.Name == toProp.Name)
                    {
                        toProp.SetValue(objTo ,baseProp.GetValue(objBase));
                    }
                }
            }
            return objTo;   
        }
    }
}
