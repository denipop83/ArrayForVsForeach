using BenchmarkDotNet.Running;

namespace ArrayForVsForeach
{
	class Program
	{
		static void Main(string[] args)
		{
			//you MUST run it under release build
			var summary = BenchmarkRunner.Run<ForVsForeach>();
		}
	}
}
