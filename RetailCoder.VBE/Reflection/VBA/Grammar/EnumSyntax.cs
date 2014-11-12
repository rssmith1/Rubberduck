﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Rubberduck.Reflection.VBA.Grammar
{
    internal class EnumSyntax : SyntaxBase
    {
        public EnumSyntax()
            : base(SyntaxType.HasChildNodes)
        { }

        protected override bool MatchesSyntax(string instruction, out Match match)
        {
            match = Regex.Match(instruction, VBAGrammar.EnumSyntax());
            return match.Success;
        }

        protected override SyntaxTreeNode CreateNode(Instruction instruction, string scope, Match match)
        {
            return new EnumNode(instruction, scope, match);
        }
    }

    internal class EnumMemberSyntax : SyntaxBase
    {
        public EnumMemberSyntax()
            : base(SyntaxType.IsChildNodeSyntax)
        { 
        }

        protected override bool MatchesSyntax(string instruction, out Match match)
        {
            match = Regex.Match(instruction, VBAGrammar.EnumMemberSyntax());
            return match.Success;
        }

        protected override SyntaxTreeNode CreateNode(Instruction instruction, string scope, Match match)
        {
            return new EnumMemberNode(instruction, scope, match);
        }
    }
}