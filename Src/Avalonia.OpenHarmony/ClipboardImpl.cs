﻿using Avalonia.Input;
using Avalonia.Input.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avalonia.OpenHarmony;

public class ClipboardImpl : IClipboard
{
    public Task ClearAsync()
    {
        throw new NotImplementedException();
    }

    public Task<object?> GetDataAsync(string format)
    {
        throw new NotImplementedException();
    }

    public Task<string[]> GetFormatsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<string?> GetTextAsync()
    {
        throw new NotImplementedException();
    }

    public Task SetDataObjectAsync(IDataObject data)
    {
        throw new NotImplementedException();
    }

    public Task SetTextAsync(string? text)
    {
        throw new NotImplementedException();
    }
}
