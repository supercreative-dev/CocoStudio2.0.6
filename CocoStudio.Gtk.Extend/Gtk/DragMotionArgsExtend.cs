﻿// Decompiled with JetBrains decompiler
// Type: Gtk.DragMotionArgsExtend
// Assembly: CocoStudio.Gtk.Extend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DBDD1FAC-46EB-4E25-BF62-EB35EC7EDA10
// Assembly location: C:\Program Files (x86)\Cocos\Cocos Studio 2\CocoStudio.Gtk.Extend.dll

using Gdk;

namespace Gtk
{
  public static class DragMotionArgsExtend
  {
    public static void SetAllowDragAction(this DragMotionArgs args, DragAction action)
    {
      Gdk.Drag.Status(args.Context, action, args.Time);
    }
  }
}
