﻿using ASBinCode;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASRuntime
{
	class PoolBase <T> where T:new()
	{

		protected T[] pool;

		int posGet;
		int posRet;

		int remain;
		public readonly int maxcount;

		public PoolBase(int maxcount)
		{
			pool = new T[maxcount];

			for (int i = 0; i < maxcount; i++)
			{
				pool[i] = new T();
			}

			remain = maxcount;
			this.maxcount = maxcount;

			posGet = 0;
			posRet = 0;
		}

		public void checkpool()
		{
			if (remain !=maxcount)
			{
				throw new EngineException("缓存池异常");
			}
		}

		public virtual void ret(T c)
		{
#if DEBUG
			if (remain == maxcount)
			{
				throw new EngineException("缓存池异常");
			}
#endif
			remain++;
			
			pool[posRet] = c;
			posRet = (posRet + 1) % maxcount ;

		}

		public void reset()
		{
			if (remain != maxcount)
			{
				remain = 0;
				posGet = 0;
				posRet = 0;

				for (int i = 0; i < maxcount; i++)
				{
					ret(pool[i]);
				}
			}
		}
		
		public virtual T create()
		{
#if DEBUG
			if (remain==0)
			{
				throw new EngineException("缓存池异常");
			}
#endif
			


			remain--;
			T r = pool[posGet];
			posGet = (posGet + 1) % maxcount;
			return r;
			
		}

		public bool hasCacheObj()
		{
			return remain > 0;
		}

	}
}
