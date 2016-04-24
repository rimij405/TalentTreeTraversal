using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE21___Talent_Tree_Traversal
{
	public class Program
	{
		public static void Main(string[] args)
		{
			// Create the TalentTree.
			TalentTree myTalentTree = new TalentTree();

			// Populate the TalentTree manually.
			TalentTreeNode root = new TalentTreeNode("Magika", true);
			TalentTreeNode level2_left = new TalentTreeNode("Blizzard", true);
			TalentTreeNode level2_right = new TalentTreeNode("Fire", true);

			root.Left = level2_left;
			root.Right = level2_right;

			TalentTreeNode level3_left1 = new TalentTreeNode("Icicle", false);
			TalentTreeNode level3_right1 = new TalentTreeNode("Blizzaga", false);

			level2_left.Left = level3_left1;
			level2_left.Right = level3_right1;

			TalentTreeNode level3_left2 = new TalentTreeNode("Pyro", false);
			TalentTreeNode level3_right2 = new TalentTreeNode("Firaga", true);

			level2_right.Left = level3_left2;
			level2_right.Right = level3_right2;

			myTalentTree.Root = root;

			Console.WriteLine("List of Known Abilities:");
			Console.WriteLine(myTalentTree.ListKnownAbilities(myTalentTree.Root));
			Console.WriteLine();
			Console.ReadLine();

			Console.WriteLine("List of Possible Abilities:");
			Console.WriteLine(myTalentTree.ListPossibleAbilities(myTalentTree.Root));
			Console.WriteLine();
			Console.ReadLine();

			Console.WriteLine("Traversal of Talent Tree:");
			myTalentTree.Traverse(myTalentTree.Root);
			Console.WriteLine();
			Console.ReadLine();
		}
	}
}
