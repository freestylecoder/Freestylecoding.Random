using System;
using System.Threading;

namespace Freestylecoding.Random {
	public class ThreadSafeRandom : System.Random {
		public ThreadSafeRandom()
			: base() {}
		public ThreadSafeRandom( int seed )
			: base( seed ) {}

		public override int Next() => this.Next( int.MaxValue );
		public override int Next( int maxValue ) => this.Next( 0, maxValue );
		public override int Next( int minValue, int maxValue ) {
			if( maxValue < minValue )
				throw new ArgumentOutOfRangeException();

			long min = minValue;
			long max = maxValue;
			long range = max - min;
			long value = (long)(range * this.Sample());
			return Convert.ToInt32( value + min );
		}

		public override void NextBytes( byte[] buffer ) {
			for( int i = 0; i < buffer.Length; ++i )
				buffer[i] = (byte)Next( byte.MinValue, byte.MaxValue );
		}

		private Mutex mutex = new Mutex();
		protected override double Sample() {
			try {
				mutex.WaitOne();
				return base.Sample();
			} finally {
				mutex.ReleaseMutex();
			}
		}
	}
}
