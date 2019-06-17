﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mochineko.ReorderableList
{
	/// <summary>
	/// An attribute to disallow edit on the Editor.
	/// Its drawer is <see cref="ReadOnlyFieldDrawer"/>.
	/// </summary>
	public class ReadOnlyFieldAttribute : PropertyAttribute
	{

	}
}