namespace UnitTestBoilerplate.Model
{
	public class MethodDescriptor
	{
		public MethodDescriptor(string name, MethodArgumentDescriptor[] methodParameters, bool isAsync, bool hasReturnType, TypeDescriptor methodReturnType)
		{
			Name = name;
			MethodParameters = methodParameters;
			IsAsync = isAsync;
			HasReturnType = hasReturnType;
			MethodReturnType = methodReturnType;
		}

		public string Name { get; }

		public MethodArgumentDescriptor[] MethodParameters { get; }

		public bool IsAsync { get; }

		public bool HasReturnType { get; }
		public TypeDescriptor MethodReturnType { get; }
	}
}