using BenchmarkDotNet.Attributes;

namespace ArrayForVsForeach
{
	[RPlotExporter]
	public class ForVsForeach
	{
		[Params(5000, 20000)] 
		public int N;

		private Complex[] _data;


		[GlobalSetup]
		public void Setup()
		{
			_data = new Complex[N];
		}

		[Benchmark]
		public void Foreach()
		{
			long counter = 0;
			foreach (var complex in _data)
			{
				counter += complex.Id;
			}
		}

		[Benchmark]
		public void For()
		{
			long counter = 0;
			for (var index = 0; index < _data.Length; index++)
			{
				var complex = _data[index];
				counter += complex.Id;
			}
		}
	}

	public readonly struct Complex
	{
		public long Id { get; }
		public long Index { get; }

		public Complex(long id, long index)
		{
			Id = id;
			Index = index;
		}
	}
}
