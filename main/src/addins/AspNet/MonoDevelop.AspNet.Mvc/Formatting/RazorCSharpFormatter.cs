﻿//
// RazorCSharpCodeFormatter.cs
//
// Author:
//		Piotr Dowgiallo <sparekd@gmail.com>
//
// Copyright (c) 2012 Piotr Dowgiallo
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MonoDevelop.Ide.CodeFormatting;
using MonoDevelop.Ide.Editor;

namespace MonoDevelop.AspNet.Mvc.Formatting
{
	public class RazorCSharpFormatter : AbstractAdvancedFormatter
	{
		public override bool SupportsOnTheFlyFormatting { get { return true; } }
		public override bool SupportsCorrectingIndent { get { return true; } }

		public override void CorrectIndenting (Projects.Policies.PolicyContainer policyParent,
			IEnumerable<string> mimeTypeChain, TextEditor data, int line)
		{
		}

		public override string FormatText (Projects.Policies.PolicyContainer policyParent,
			IEnumerable<string> mimeTypeChain, string input, int startOffset, int endOffset)
		{
			return null;
		}

		public override void OnTheFlyFormat (Ide.Gui.Document doc, int startOffset, int endOffset)
		{
		}
	}
}
