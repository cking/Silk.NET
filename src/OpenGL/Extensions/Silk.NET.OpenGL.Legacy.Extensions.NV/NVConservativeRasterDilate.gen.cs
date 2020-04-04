// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_conservative_raster_dilate")]
    public abstract unsafe partial class NVConservativeRasterDilate : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glConservativeRasterParameterfNV")]
        public abstract void ConservativeRasterParameter([Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] float value);

        public NVConservativeRasterDilate(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}
