﻿// Decompiled with JetBrains decompiler
// Type: CocoStudio.Model.Event.PasteObjectsChangeEventArgs
// Assembly: CocoStudio.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9A645332-034C-44D3-9062-5E94EDCB75FF
// Assembly location: C:\Program Files (x86)\Cocos\Cocos Studio 2\CocoStudio.Model.dll

namespace CocoStudio.Model.Event
{
  public class PasteObjectsChangeEventArgs
  {
    public PointF PastePosition { get; set; }

    public PasteObjectsChangeEventArgs(PointF position)
    {
      this.PastePosition = position;
    }
  }
}