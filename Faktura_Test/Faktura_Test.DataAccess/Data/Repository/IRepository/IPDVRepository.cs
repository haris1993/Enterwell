using Faktura_Test.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;
using Uplift.Models;

namespace Uplift.DataAccess.Data.Repository.IRepository
{
    public interface IPDVRepository : IRepository<PDV>
    {
        IEnumerable<SelectListItem> GetPDVListForDropDown();

        void Update(PDV pdv);
    }
}
