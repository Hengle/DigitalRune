﻿// DigitalRune Engine - Copyright (C) DigitalRune GmbH
// This file is subject to the terms and conditions defined in
// file 'LICENSE.TXT', which is part of this source code package.


namespace DigitalRune.Windows.Framework
{
    /// <summary>
    /// Displays the content of a Help file.
    /// </summary>
    public interface IHelpProvider
    {
        // Note: Code analyzer recommends to use URI instead of strings. We keep strings in case
        // the ShowHelp method wants to use something more general which does not conform to an
        // URI format.

        /// <overloads>
        /// <summary>
        /// Displays the contents of the Help file found at the specified URL.
        /// </summary>
        /// </overloads>
        /// 
        /// <summary>
        /// Displays the contents of the Help file found at the specified URL.
        /// </summary>
        /// <param name="url">The path and name of the Help file.</param>
        /// <remarks>
        /// The <paramref name="url"/> parameter can be of the form C:\path\sample.chm or
        /// /folder/file.htm.
        /// </remarks>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", MessageId = "0#")]
        void ShowHelp(string url);


        /// <summary>
        /// Displays the contents of the Help file found at the specified URL for a specific
        /// keyword.
        /// </summary>
        /// <param name="url">The path and name of the Help file.</param>
        /// <param name="keyword">The keyword to display Help for.</param>
        /// <remarks>
        /// The <paramref name="url"/> parameter can be of the form C:\path\sample.chm or
        /// /folder/file.htm. If you provide the keyword <see langword="null"/>, the table of
        /// contents for the Help file will be displayed.
        /// </remarks>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", MessageId = "0#")]
        void ShowHelp(string url, string keyword);
    }
}
