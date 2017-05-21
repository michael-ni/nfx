/*<FILE_LICENSE>
* NFX (.NET Framework Extension) Unistack Library
* Copyright 2003-2017 ITAdapter Corp. Inc.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
</FILE_LICENSE>*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFX.DataAccess.CRUD
{
  /// <summary>
  /// Checks for reference equality. Use RowEqualityComparer.Instance
  /// </summary>
  public sealed class RowEqualityComparer : EqualityComparer<Row>
  {
      private static RowEqualityComparer s_Instance = new RowEqualityComparer();

      public static RowEqualityComparer Instance { get { return s_Instance;}}

      private RowEqualityComparer() {}


      public override bool Equals(Row x, Row y)
      {
        if (x==null && y==null) return true;
        if (x==null) return false;

        return x.Equals(y);
      }

      public override int GetHashCode(Row row)
      {
        if (row==null) return 0;
        return row.GetHashCode();
      }
  }
}