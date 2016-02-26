using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Behavioral.Iterator
{
    /// <summary>
    /// Concrete Iterator
    /// </summary>
    class ComplexObjectIterator : Iterator
    {
        private readonly ComplexObject _object;
        private ComplexObject _currentObject;
        private int _currentIndex;

        /// <summary>
        /// Initialized with Iterable object
        /// </summary>
        /// <param name="object"></param>
        public ComplexObjectIterator(ComplexObject @object)
        {
            _object = _currentObject =  @object;
        }

        public override object Current()
        {
            return _currentObject.Items[_currentIndex];
        }

        public override object Next()
        {
            if (!HasNextItem())
            {
                // Switch to child object
                _currentObject = _currentObject?.Child;
                _currentIndex = -1;
            }
            return HasNext() ? _currentObject?.Items[++_currentIndex] : null;
        }

        public override bool HasNext()
        {           
            return HasNextItem() || _currentObject?.Child != null;
        }

        public override bool IsDone()
        {
            return _currentObject == null;
        }

        public override void Reset()
        {
            _currentObject = _object;
            _currentIndex = 0;
        }

        #region private methods
        private bool HasNextItem()
        {
            return _currentIndex < _currentObject?.Items.Count - 1;
        }        
        #endregion


    }
}
