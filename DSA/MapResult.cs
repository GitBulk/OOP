using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    public class MapResult<TValue, TResult>
    {
        private bool MatchedPreviously { get; set; }
        public TValue OriginalValue { get; set; }
        public TResult Result { get; set; }

        internal MapResult(TValue value, TResult result = default(TResult), bool matchedPreviously = false)
        {
            this.OriginalValue = value;
            this.Result = result;
            this.MatchedPreviously = matchedPreviously;
        }

        public MapResult<TValue, TResult> Map(TValue ifValue, TResult thenValue)
        {
            return Map(x => x.Equals(ifValue), x => thenValue);
        }

        public MapResult<TValue, TResult> Map(TValue ifValue, Func<TValue, TResult> thenFunc)
        {
            return Map(x => x.Equals(ifValue), thenFunc);
        }

        public MapResult<TValue, TResult> Map(Func<TValue, bool> ifFunction, TResult thenValue)
        {
            return Map(ifFunction, x => thenValue);
        }

        public MapResult<TValue, TResult> Map(Func<TValue, bool> ifFunction, Func<TValue, TResult> thenFunction)
        {
            if (MatchedPreviously || !ifFunction(OriginalValue))
            {
                return this;
            }
            var result = new MapResult<TValue, TResult>(OriginalValue, thenFunction(OriginalValue), true);
            return result;
        }

        public TResult Else(TResult elseValue)
        {
            return Else(x => elseValue);
        }

        public TResult Else(Func<object, TResult> elseFunction)
        {
            if (this.MatchedPreviously)
            {
                return this.Result;
            }
            var result = elseFunction(this.OriginalValue);
            return result;
        }

        public TResult ElseDo(Action<TValue> doThis)
        {
            if (MatchedPreviously)
            {
                return this.Result;
            }
            doThis(this.OriginalValue);
            return this.Result;
        }

        public static implicit operator TResult(MapResult<TValue, TResult> value)
        {
            return value.Result;
        }
    }
}
