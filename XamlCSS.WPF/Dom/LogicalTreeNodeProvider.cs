﻿using System.Collections.Generic;
using System.Linq;
using System.Windows;
using XamlCSS.Dom;

namespace XamlCSS.WPF.Dom
{
    //public class LogicalTreeNodeProvider : TreeNodeProviderBase<DependencyObject, Style, DependencyProperty>
    //{
    //    public LogicalTreeNodeProvider(IDependencyPropertyService<DependencyObject, Style, DependencyProperty> dependencyPropertyService)
    //        : base(dependencyPropertyService, SelectorType.LogicalTree)
    //    {
    //    }

    //    public override IDomElement<DependencyObject> CreateTreeNode(DependencyObject dependencyObject)
    //    {
    //        return new LogicalDomElement(dependencyObject, GetDomElement(GetParent(dependencyObject)), this, namespaceProvider);
    //    }

    //    public override IEnumerable<DependencyObject> GetLogicalChildren(DependencyObject element)
    //    {
    //        if (element == null)
    //        {
    //            return new List<DependencyObject>();
    //        }

    //        var a = LogicalTreeHelper.GetChildren(element)
    //            .Cast<object>()
    //            .OfType<DependencyObject>()
    //            .ToList();

    //        return a;
    //    }

    //    public override DependencyObject GetLogicalParent(DependencyObject element)
    //    {
    //        if (element == null)
    //        {
    //            return null;
    //        }

    //        return LogicalTreeHelper.GetParent(element);
    //    }

    //    public override bool IsInLogicalTree(DependencyObject dependencyObject)
    //    {
    //        var p = GetParent(dependencyObject);
    //        if (p == null)
    //            return dependencyObject is Window;

    //        return GetChildren(p).Contains(dependencyObject);
    //    }
    //}
}
