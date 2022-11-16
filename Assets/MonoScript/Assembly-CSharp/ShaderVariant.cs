using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

public class ShaderVariant
{
	private Dictionary<string, bool> unityKeywords;

	private Dictionary<string, bool> waterKeywords;

	private Dictionary<string, string> shaderParts;

	[CompilerGenerated]
	private static Func<string, string> _003C_003Ef__am_0024cache0;

	[CompilerGenerated]
	private static Func<string, string> _003C_003Ef__am_0024cache1;

	[CompilerGenerated]
	private static Func<string, string> _003C_003Ef__am_0024cache2;

	public ShaderVariant()
	{
		unityKeywords = new Dictionary<string, bool>();
		waterKeywords = new Dictionary<string, bool>();
		shaderParts = new Dictionary<string, string>();
	}

	public void SetUnityKeyword(string keyword, bool value)
	{
		if (value)
		{
			unityKeywords[keyword] = true;
		}
		else
		{
			unityKeywords.Remove(keyword);
		}
	}

	public void SetWaterKeyword(string keyword, bool value)
	{
		if (value)
		{
			waterKeywords[keyword] = value;
		}
		else
		{
			waterKeywords.Remove(keyword);
		}
	}

	public void SetAdditionalCode(string keyword, string code)
	{
		if (code != null)
		{
			shaderParts[keyword] = code;
		}
		else
		{
			shaderParts.Remove(keyword);
		}
	}

	public bool IsUnityKeywordEnabled(string keyword)
	{
		bool value;
		if (unityKeywords.TryGetValue(keyword, out value))
		{
			return true;
		}
		return false;
	}

	public bool IsWaterKeywordEnabled(string keyword)
	{
		bool value;
		if (waterKeywords.TryGetValue(keyword, out value))
		{
			return true;
		}
		return false;
	}

	public string GetAdditionalCode()
	{
		StringBuilder stringBuilder = new StringBuilder(512);
		foreach (string value in shaderParts.Values)
		{
			stringBuilder.Append(value);
		}
		return stringBuilder.ToString();
	}

	public string[] GetUnityKeywords()
	{
		string[] array = new string[unityKeywords.Count];
		int num = 0;
		foreach (string key in unityKeywords.Keys)
		{
			array[num++] = key;
		}
		return array;
	}

	public string[] GetWaterKeywords()
	{
		string[] array = new string[waterKeywords.Count];
		int num = 0;
		foreach (string key in waterKeywords.Keys)
		{
			array[num++] = key;
		}
		return array;
	}

	public string GetKeywordsString()
	{
		StringBuilder stringBuilder = new StringBuilder(512);
		bool flag = false;
		Dictionary<string, bool>.KeyCollection keys = waterKeywords.Keys;
		if (_003C_003Ef__am_0024cache0 == null)
		{
			_003C_003Ef__am_0024cache0 = _003CGetKeywordsString_003Em__0;
		}
		foreach (string item in keys.OrderBy(_003C_003Ef__am_0024cache0))
		{
			if (flag)
			{
				stringBuilder.Append(' ');
			}
			else
			{
				flag = true;
			}
			stringBuilder.Append(item);
		}
		Dictionary<string, bool>.KeyCollection keys2 = unityKeywords.Keys;
		if (_003C_003Ef__am_0024cache1 == null)
		{
			_003C_003Ef__am_0024cache1 = _003CGetKeywordsString_003Em__1;
		}
		foreach (string item2 in keys2.OrderBy(_003C_003Ef__am_0024cache1))
		{
			if (flag)
			{
				stringBuilder.Append(' ');
			}
			else
			{
				flag = true;
			}
			stringBuilder.Append(item2);
		}
		Dictionary<string, string>.KeyCollection keys3 = shaderParts.Keys;
		if (_003C_003Ef__am_0024cache2 == null)
		{
			_003C_003Ef__am_0024cache2 = _003CGetKeywordsString_003Em__2;
		}
		foreach (string item3 in keys3.OrderBy(_003C_003Ef__am_0024cache2))
		{
			if (flag)
			{
				stringBuilder.Append(' ');
			}
			else
			{
				flag = true;
			}
			stringBuilder.Append(item3);
		}
		return stringBuilder.ToString();
	}

	[CompilerGenerated]
	private static string _003CGetKeywordsString_003Em__0(string k)
	{
		return k;
	}

	[CompilerGenerated]
	private static string _003CGetKeywordsString_003Em__1(string k)
	{
		return k;
	}

	[CompilerGenerated]
	private static string _003CGetKeywordsString_003Em__2(string k)
	{
		return k;
	}
}
