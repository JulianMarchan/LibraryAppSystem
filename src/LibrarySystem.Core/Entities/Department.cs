using Abp.Authorization.Users;
using Abp.Domain.Entities.Auditing;
using Abp.MultiTenancy;
using Castle.Components.DictionaryAdapter;
using LibrarySystem.Authorization.Users;
using LibrarySystem.MultiTenancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Entities
{
    public class Department: FullAuditedEntity<int>
    {
        public string Name { get; set; } //column sa table field "name" PROPERTY
      
    }

}
