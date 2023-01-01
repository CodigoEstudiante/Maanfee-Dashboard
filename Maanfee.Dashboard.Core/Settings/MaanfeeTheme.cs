﻿using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maanfee.Dashboard.Core
{
	public static class MaanfeeTheme
	{
		#region - Change Default MudBlazor Font -

		//CurrentTheme.Typography = new Typography()
		//{
		//    Default = new Default()
		//    {
		//        FontFamily = new[] { "BYekan", "Tahoma", "Arial", "Helvetica", "sans-serif" }
		//    }
		//    };

		#endregion

		private static string[] EnglishFont = new[] { "Montserrat", "Helvetica", "Arial", "sans-serif" };
		private static string[] PersianFont = new[] { "BYekan", "Tahoma", "Arial", "Helvetica", "sans-serif" };

		private static Typography LtrTypography = new Typography()
		{
			Default = new Default()
			{
				FontFamily = EnglishFont,
				FontSize = ".875rem",
				FontWeight = 400,
				LineHeight = 1.43,
				LetterSpacing = ".01071em"
			},
			H1 = new H1()
			{
				FontFamily = EnglishFont,
				FontSize = "6rem",
				FontWeight = 300,
				LineHeight = 1.167,
				LetterSpacing = "-.01562em"
			},
			H2 = new H2()
			{
				FontFamily = EnglishFont,
				FontSize = "3.75rem",
				FontWeight = 300,
				LineHeight = 1.2,
				LetterSpacing = "-.00833em"
			},
			H3 = new H3()
			{
				FontFamily = EnglishFont,
				FontSize = "3rem",
				FontWeight = 400,
				LineHeight = 1.167,
				LetterSpacing = "0"
			},
			H4 = new H4()
			{
				FontFamily = EnglishFont,
				FontSize = "2.125rem",
				FontWeight = 400,
				LineHeight = 1.235,
				LetterSpacing = ".00735em"
			},
			H5 = new H5()
			{
				FontFamily = EnglishFont,
				FontSize = "1.5rem",
				FontWeight = 400,
				LineHeight = 1.334,
				LetterSpacing = "0"
			},
			H6 = new H6()
			{
				FontFamily = EnglishFont,
				FontSize = "1.25rem",
				FontWeight = 400,
				LineHeight = 1.6,
				LetterSpacing = ".0075em"
			},
			Button = new Button()
			{
				FontFamily = EnglishFont,
				FontSize = ".875rem",
				FontWeight = 500,
				LineHeight = 1.75,
				LetterSpacing = ".02857em"
			},
			Body1 = new Body1()
			{
				FontFamily = EnglishFont,
				FontSize = "1rem",
				FontWeight = 400,
				LineHeight = 1.5,
				LetterSpacing = ".00938em"
			},
			Body2 = new Body2()
			{
				FontFamily = EnglishFont,
				FontSize = ".875rem",
				FontWeight = 400,
				LineHeight = 1.43,
				LetterSpacing = ".01071em"
			},
			Caption = new Caption()
			{
				FontFamily = EnglishFont,
				FontSize = ".75rem",
				FontWeight = 400,
				LineHeight = 1.66,
				LetterSpacing = ".03333em"
			},
			Subtitle2 = new Subtitle2()
			{
				FontFamily = EnglishFont,
				FontSize = ".875rem",
				FontWeight = 500,
				LineHeight = 1.57,
				LetterSpacing = ".00714em"
			}
		};

		private static Typography RtlTypography = new Typography()
		{
			Default = new Default()
			{
				FontFamily = PersianFont,
				FontSize = ".875rem",
				FontWeight = 400,
				LineHeight = 1.43,
				LetterSpacing = ".01071em"
			},
			H1 = new H1()
			{
				FontFamily = PersianFont,
				FontSize = "6rem",
				FontWeight = 300,
				LineHeight = 1.167,
				LetterSpacing = "-.01562em"
			},
			H2 = new H2()
			{
				FontFamily = PersianFont,
				FontSize = "3.75rem",
				FontWeight = 300,
				LineHeight = 1.2,
				LetterSpacing = "-.00833em"
			},
			H3 = new H3()
			{
				FontFamily = PersianFont,
				FontSize = "3rem",
				FontWeight = 400,
				LineHeight = 1.167,
				LetterSpacing = "0"
			},
			H4 = new H4()
			{
				FontFamily = PersianFont,
				FontSize = "2.125rem",
				FontWeight = 400,
				LineHeight = 1.235,
				LetterSpacing = ".00735em"
			},
			H5 = new H5()
			{
				FontFamily = PersianFont,
				FontSize = "1.5rem",
				FontWeight = 400,
				LineHeight = 1.334,
				LetterSpacing = "0"
			},
			H6 = new H6()
			{
				FontFamily = PersianFont,
				FontSize = "1.25rem",
				FontWeight = 400,
				LineHeight = 1.6,
				LetterSpacing = ".0075em"
			},
			Button = new Button()
			{
				FontFamily = PersianFont,
				FontSize = ".875rem",
				FontWeight = 500,
				LineHeight = 1.75,
				LetterSpacing = ".02857em"
			},
			Body1 = new Body1()
			{
				FontFamily = PersianFont,
				FontSize = "1rem",
				FontWeight = 400,
				LineHeight = 1.5,
				LetterSpacing = ".00938em"
			},
			Body2 = new Body2()
			{
				FontFamily = PersianFont,
				FontSize = ".875rem",
				FontWeight = 400,
				LineHeight = 1.43,
				LetterSpacing = ".01071em"
			},
			Caption = new Caption()
			{
				FontFamily = PersianFont,
				FontSize = ".75rem",
				FontWeight = 400,
				LineHeight = 1.66,
				LetterSpacing = ".03333em"
			},
			Subtitle2 = new Subtitle2()
			{
				FontFamily = PersianFont,
				FontSize = ".875rem",
				FontWeight = 500,
				LineHeight = 1.57,
				LetterSpacing = ".00714em"
			}
		};

		private static LayoutProperties DefaultLayoutProperties = new LayoutProperties()
		{
			DefaultBorderRadius = "3px"
		};

		//public static MudTheme DarkTheme = new MudTheme()
		//{
		//	Palette = new Palette()
		//	{
		//		Primary = "#1E88E5",
		//		Success = "#007E33",
		//		Black = "#27272f",
		//		Background = "#32333d",
		//		BackgroundGrey = "#27272f",
		//		Surface = "#373740",
		//		DrawerBackground = "#27272f",
		//		DrawerText = "rgba(255,255,255, 0.50)",
		//		AppbarBackground = "#373740",
		//		AppbarText = "rgba(255,255,255, 0.70)",
		//		TextPrimary = "rgba(255,255,255, 0.70)",
		//		TextSecondary = "rgba(255,255,255, 0.50)",
		//		ActionDefault = "#adadb1",
		//		ActionDisabled = "rgba(255,255,255, 0.26)",
		//		ActionDisabledBackground = "rgba(255,255,255, 0.12)",
		//		DrawerIcon = "rgba(255,255,255, 0.50)"
		//	},
		//	//Typography = DefaultTypography,
		//	Typography = PersianTypography,
		//	LayoutProperties = DefaultLayoutProperties
		//};

		public static MudTheme ThemeBuilder(bool IsRtl, bool IsDark)
		{
			return new MudTheme()
			{
				//Palette = new Palette()
				//{
				//	Primary = "#1E88E5",
				//	AppbarBackground = "#1E88E5",
				//	Background = Colors.Grey.Lighten5,
				//	DrawerBackground = "#FFF",
				//	DrawerText = "rgba(0,0,0, 0.7)",
				//	Success = "#007E33"
				//},
				Typography = (IsRtl) ? RtlTypography : LtrTypography,
				LayoutProperties = DefaultLayoutProperties
			};
		}

	}
}
