using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE21___Talent_Tree_Traversal
{
	// Binary search tree for talent traversal.
	public class TalentTree
	{
		// Attributes
		private TalentTreeNode root = null;

		// Properties
		public TalentTreeNode Root
		{
			get { return this.root; }
			set { this.root = value; }
		}

		// Insert methods.
		public void Insert(string ability, bool attained)
		{
			if (root == null)
			{
				root = new TalentTreeNode(ability, attained);
			}
			else
			{
				Insert(ability, attained, root);
			}
		}

		private void Insert(string ability, bool attained, TalentTreeNode current)
		{
			// If less than current value.
			if (String.Compare(ability, current.Ability) < 0)
			{
				// try to add node to the left
				if (current.Left == null)  // space is available
				{
					current.Left = new TalentTreeNode(ability, attained);
				}
				else // space is already occupied
				{
					Insert(ability, attained, current.Left); // go down a level and do the same thing
				}
			}
			else // greater than or equal to current value, go right
			{
				// try to add the node to right
				if (current.Right == null)
				{
					current.Right = new TalentTreeNode(ability, attained);
				}
				else // space occupied
				{
					Insert(ability, attained, current.Right);
				}
			}
		}

		// traverse the tree in order
		public void Traverse(TalentTreeNode current)
		{
			if (current != null)
			{
				Traverse(current.Left);
				Console.Write(current.Ability + " ");
				Traverse(current.Right);
			}
		}

		// List Known Abilities.
		// Prints out all abilities that the player knows.
		public string ListKnownAbilities(TalentTreeNode node)
		{
			string list = "";

			// If not achieved none of its children can be achieved either.
			// So do not return a value for this.

			if (node == null || !node.Achieved)
			{
				list += "";
			}
			// If it IS achieved:
			else
			{
				// Add the node to the list if not achieved.
				if (node.Achieved)
				{
					list += node.Ability + " ";
				}

				// Check to see if its left children nodes can also be added if they aren't null and ARE achieved.
				if (node.Left != null)
				{
					list += ListKnownAbilities(node.Left);
				}

				// Check to see if its right children nodes can also be added if they aren't null and ARE achieved.
				if (node.Right != null)
				{
					list += ListKnownAbilities(node.Right);
				}
			}

			// Returns whatever may come out of the recursive process.
			return list;
		}

		// List Possible Abilities.
		// Prints out abilities that the player could learn next.
		public string ListPossibleAbilities(TalentTreeNode node)
		{
			string list = "";

			// If not achieved none of its children can be achieved either.
			// So do not return a value for this.

			if (node == null || !node.Achieved)
			{
				list += "";
			}
			// If it IS achieved:
			else
			{
				// Check to see if its left children nodes can also be added if they aren't null and ARE achieved.
				if (node.Left != null && node.Left.Achieved)
				{
					list += ListPossibleAbilities(node.Left);
				}
				else if (node.Left != null && !node.Left.Achieved)
				{
					list += node.Left.Ability + " ";
				}

				// Check to see if its right children nodes can also be added if they aren't null and ARE achieved.
				if (node.Right != null && node.Right.Achieved)
				{
					list += ListPossibleAbilities(node.Right);
				}
				else if (node.Right != null && !node.Right.Achieved)
				{
					list += node.Right.Ability + " ";
				}
			}

			// Returns whatever may come out of the recursive process.
			return list;
		}
		
	}
}
