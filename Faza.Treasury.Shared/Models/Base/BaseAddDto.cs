using Bitspco.Framework.Common.Exceptions;
using Bitspco.Framework.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Faza.Treasury.Shared.Models
{
    public class BaseAddDto : IValidation
    {
        public virtual ValidationException Validate()
        {
            return new ValidationException();
        }
    }
}
