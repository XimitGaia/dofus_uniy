using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000AD8")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ObjectEffect : IMessage<ObjectEffect>, IMessage, IEquatable<ObjectEffect>, IDeepCloneable<ObjectEffect>, IBufferMessage
{
	[Token(Token = "0x2000AD9")]
	public enum EffectOneofCase
	{
		[Token(Token = "0x40027D1")]
		None = 0,
		[Token(Token = "0x40027D2")]
		ValueString = 2,
		[Token(Token = "0x40027D3")]
		ValueInt = 3,
		[Token(Token = "0x40027D4")]
		MinMax = 4,
		[Token(Token = "0x40027D5")]
		Dice = 5,
		[Token(Token = "0x40027D6")]
		Date = 6,
		[Token(Token = "0x40027D7")]
		DurationMinute = 7,
		[Token(Token = "0x40027D8")]
		CreatureFamily = 8,
		[Token(Token = "0x40027D9")]
		MonsterCount = 9,
		[Token(Token = "0x40027DA")]
		Mount = 10
	}

	[Token(Token = "0x2000ADA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x2000ADB")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class DofusDate : IMessage<DofusDate>, IMessage, IEquatable<DofusDate>, IDeepCloneable<DofusDate>, IBufferMessage
		{
			[Token(Token = "0x40027DB")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<DofusDate> _parser;

			[Token(Token = "0x40027DC")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x40027DD")]
			public const int YearFieldNumber = 1;

			[Token(Token = "0x40027DE")]
			[FieldOffset(Offset = "0x18")]
			private int year_;

			[Token(Token = "0x40027DF")]
			public const int MonthFieldNumber = 2;

			[Token(Token = "0x40027E0")]
			[FieldOffset(Offset = "0x1C")]
			private int month_;

			[Token(Token = "0x40027E1")]
			public const int DayFieldNumber = 3;

			[Token(Token = "0x40027E2")]
			[FieldOffset(Offset = "0x20")]
			private int day_;

			[Token(Token = "0x40027E3")]
			public const int HourFieldNumber = 4;

			[Token(Token = "0x40027E4")]
			[FieldOffset(Offset = "0x24")]
			private int hour_;

			[Token(Token = "0x40027E5")]
			public const int MinuteFieldNumber = 5;

			[Token(Token = "0x40027E6")]
			[FieldOffset(Offset = "0x28")]
			private int minute_;

			[Token(Token = "0x170018E0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageParser<DofusDate> Parser
			{
				[Token(Token = "0x60071D8")]
				[Address(RVA = "0xBF0C40", Offset = "0xBF0040", VA = "0x180BF0C40")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170018E1")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x60071D9")]
				[Address(RVA = "0xBF0BC0", Offset = "0xBEFFC0", VA = "0x180BF0BC0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170018E2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x60071DA")]
				[Address(RVA = "0xBF0C90", Offset = "0xBF0090", VA = "0x180BF0C90", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170018E3")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int Year
			{
				[Token(Token = "0x60071DE")]
				[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x60071DF")]
				[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
				set
				{
				}
			}

			[Token(Token = "0x170018E4")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int Month
			{
				[Token(Token = "0x60071E0")]
				[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x60071E1")]
				[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
				set
				{
				}
			}

			[Token(Token = "0x170018E5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int Day
			{
				[Token(Token = "0x60071E2")]
				[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x60071E3")]
				[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
				set
				{
				}
			}

			[Token(Token = "0x170018E6")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int Hour
			{
				[Token(Token = "0x60071E4")]
				[Address(RVA = "0x87D140", Offset = "0x87C540", VA = "0x18087D140")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x60071E5")]
				[Address(RVA = "0x9342C0", Offset = "0x9336C0", VA = "0x1809342C0")]
				set
				{
				}
			}

			[Token(Token = "0x170018E7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int Minute
			{
				[Token(Token = "0x60071E6")]
				[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x60071E7")]
				[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
				set
				{
				}
			}

			[Token(Token = "0x60071DB")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public DofusDate()
			{
			}

			[Token(Token = "0x60071DC")]
			[Address(RVA = "0xA55430", Offset = "0xA54830", VA = "0x180A55430")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public DofusDate(DofusDate other)
			{
			}

			[Token(Token = "0x60071DD")]
			[Address(RVA = "0xBF0910", Offset = "0xBEFD10", VA = "0x180BF0910", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public DofusDate Clone()
			{
				return null;
			}

			[Token(Token = "0x60071E8")]
			[Address(RVA = "0xBF09B0", Offset = "0xBEFDB0", VA = "0x180BF09B0", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x60071E9")]
			[Address(RVA = "0xA55120", Offset = "0xA54520", VA = "0x180A55120", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(DofusDate other)
			{
				return default(bool);
			}

			[Token(Token = "0x60071EA")]
			[Address(RVA = "0xA55170", Offset = "0xA54570", VA = "0x180A55170", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x60071EB")]
			[Address(RVA = "0xBF0A60", Offset = "0xBEFE60", VA = "0x180BF0A60", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x60071EC")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x60071ED")]
			[Address(RVA = "0xA556B0", Offset = "0xA54AB0", VA = "0x180A556B0", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x60071EE")]
			[Address(RVA = "0xBF07E0", Offset = "0xBEFBE0", VA = "0x180BF07E0", Slot = "7")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x60071EF")]
			[Address(RVA = "0xA55250", Offset = "0xA54650", VA = "0x180A55250", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(DofusDate other)
			{
			}

			[Token(Token = "0x60071F0")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x60071F1")]
			[Address(RVA = "0xA555A0", Offset = "0xA549A0", VA = "0x180A555A0", Slot = "11")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}

		[Token(Token = "0x2000ADD")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class ObjectEffectMinMaxValue : IMessage<ObjectEffectMinMaxValue>, IMessage, IEquatable<ObjectEffectMinMaxValue>, IDeepCloneable<ObjectEffectMinMaxValue>, IBufferMessage
		{
			[Token(Token = "0x40027E8")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<ObjectEffectMinMaxValue> _parser;

			[Token(Token = "0x40027E9")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x40027EA")]
			public const int MinFieldNumber = 1;

			[Token(Token = "0x40027EB")]
			[FieldOffset(Offset = "0x18")]
			private int min_;

			[Token(Token = "0x40027EC")]
			public const int MaxFieldNumber = 2;

			[Token(Token = "0x40027ED")]
			[FieldOffset(Offset = "0x1C")]
			private int max_;

			[Token(Token = "0x170018E8")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageParser<ObjectEffectMinMaxValue> Parser
			{
				[Token(Token = "0x60071F6")]
				[Address(RVA = "0xBF2D00", Offset = "0xBF2100", VA = "0x180BF2D00")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170018E9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x60071F7")]
				[Address(RVA = "0xBF2C80", Offset = "0xBF2080", VA = "0x180BF2C80")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170018EA")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x60071F8")]
				[Address(RVA = "0xBF2D50", Offset = "0xBF2150", VA = "0x180BF2D50", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170018EB")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int Min
			{
				[Token(Token = "0x60071FC")]
				[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x60071FD")]
				[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
				set
				{
				}
			}

			[Token(Token = "0x170018EC")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int Max
			{
				[Token(Token = "0x60071FE")]
				[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x60071FF")]
				[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
				set
				{
				}
			}

			[Token(Token = "0x60071F9")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public ObjectEffectMinMaxValue()
			{
			}

			[Token(Token = "0x60071FA")]
			[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public ObjectEffectMinMaxValue(ObjectEffectMinMaxValue other)
			{
			}

			[Token(Token = "0x60071FB")]
			[Address(RVA = "0xBF2A00", Offset = "0xBF1E00", VA = "0x180BF2A00", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public ObjectEffectMinMaxValue Clone()
			{
				return null;
			}

			[Token(Token = "0x6007200")]
			[Address(RVA = "0xBF2A90", Offset = "0xBF1E90", VA = "0x180BF2A90", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6007201")]
			[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool Equals(ObjectEffectMinMaxValue other)
			{
				return default(bool);
			}

			[Token(Token = "0x6007202")]
			[Address(RVA = "0x9691C0", Offset = "0x9685C0", VA = "0x1809691C0", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6007203")]
			[Address(RVA = "0xBF2B20", Offset = "0xBF1F20", VA = "0x180BF2B20", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6007204")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6007205")]
			[Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "12")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6007206")]
			[Address(RVA = "0xBF2940", Offset = "0xBF1D40", VA = "0x180BF2940", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6007207")]
			[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(ObjectEffectMinMaxValue other)
			{
			}

			[Token(Token = "0x6007208")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6007209")]
			[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}

		[Token(Token = "0x2000ADF")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class ObjectEffectDiceValue : IMessage<ObjectEffectDiceValue>, IMessage, IEquatable<ObjectEffectDiceValue>, IDeepCloneable<ObjectEffectDiceValue>, IBufferMessage
		{
			[Token(Token = "0x40027EF")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<ObjectEffectDiceValue> _parser;

			[Token(Token = "0x40027F0")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x40027F1")]
			public const int NumFieldNumber = 1;

			[Token(Token = "0x40027F2")]
			[FieldOffset(Offset = "0x18")]
			private long num_;

			[Token(Token = "0x40027F3")]
			public const int SideFieldNumber = 2;

			[Token(Token = "0x40027F4")]
			[FieldOffset(Offset = "0x20")]
			private int side_;

			[Token(Token = "0x40027F5")]
			public const int ConstFieldNumber = 3;

			[Token(Token = "0x40027F6")]
			[FieldOffset(Offset = "0x24")]
			private int const_;

			[Token(Token = "0x170018ED")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageParser<ObjectEffectDiceValue> Parser
			{
				[Token(Token = "0x600720E")]
				[Address(RVA = "0xBF2840", Offset = "0xBF1C40", VA = "0x180BF2840")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170018EE")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x600720F")]
				[Address(RVA = "0xBF27C0", Offset = "0xBF1BC0", VA = "0x180BF27C0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170018EF")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6007210")]
				[Address(RVA = "0xBF2890", Offset = "0xBF1C90", VA = "0x180BF2890", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170018F0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public long Num
			{
				[Token(Token = "0x6007214")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x6007215")]
				[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
				set
				{
				}
			}

			[Token(Token = "0x170018F1")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int Side
			{
				[Token(Token = "0x6007216")]
				[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6007217")]
				[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
				set
				{
				}
			}

			[Token(Token = "0x170018F2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int Const
			{
				[Token(Token = "0x6007218")]
				[Address(RVA = "0x87D140", Offset = "0x87C540", VA = "0x18087D140")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6007219")]
				[Address(RVA = "0x9342C0", Offset = "0x9336C0", VA = "0x1809342C0")]
				set
				{
				}
			}

			[Token(Token = "0x6007211")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public ObjectEffectDiceValue()
			{
			}

			[Token(Token = "0x6007212")]
			[Address(RVA = "0x9D5350", Offset = "0x9D4750", VA = "0x1809D5350")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public ObjectEffectDiceValue(ObjectEffectDiceValue other)
			{
			}

			[Token(Token = "0x6007213")]
			[Address(RVA = "0xBF2530", Offset = "0xBF1930", VA = "0x180BF2530", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public ObjectEffectDiceValue Clone()
			{
				return null;
			}

			[Token(Token = "0x600721A")]
			[Address(RVA = "0xBF25C0", Offset = "0xBF19C0", VA = "0x180BF25C0", Slot = "0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x600721B")]
			[Address(RVA = "0x9D4FF0", Offset = "0x9D43F0", VA = "0x1809D4FF0", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(ObjectEffectDiceValue other)
			{
				return default(bool);
			}

			[Token(Token = "0x600721C")]
			[Address(RVA = "0x9D50D0", Offset = "0x9D44D0", VA = "0x1809D50D0", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x600721D")]
			[Address(RVA = "0xBF2660", Offset = "0xBF1A60", VA = "0x180BF2660", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x600721E")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x600721F")]
			[Address(RVA = "0x9D5580", Offset = "0x9D4980", VA = "0x1809D5580", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6007220")]
			[Address(RVA = "0xBF2450", Offset = "0xBF1850", VA = "0x180BF2450", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6007221")]
			[Address(RVA = "0x9D5180", Offset = "0x9D4580", VA = "0x1809D5180", Slot = "4")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(ObjectEffectDiceValue other)
			{
			}

			[Token(Token = "0x6007222")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6007223")]
			[Address(RVA = "0x9D54B0", Offset = "0x9D48B0", VA = "0x1809D54B0", Slot = "11")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}

		[Token(Token = "0x2000AE1")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class MonsterCount : IMessage<MonsterCount>, IMessage, IEquatable<MonsterCount>, IDeepCloneable<MonsterCount>, IBufferMessage
		{
			[Token(Token = "0x40027F8")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<MonsterCount> _parser;

			[Token(Token = "0x40027F9")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x40027FA")]
			public const int CreatureFamilyFieldNumber = 1;

			[Token(Token = "0x40027FB")]
			[FieldOffset(Offset = "0x18")]
			private int creatureFamily_;

			[Token(Token = "0x40027FC")]
			public const int CountFieldNumber = 2;

			[Token(Token = "0x40027FD")]
			[FieldOffset(Offset = "0x1C")]
			private int count_;

			[Token(Token = "0x170018F3")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<MonsterCount> Parser
			{
				[Token(Token = "0x6007228")]
				[Address(RVA = "0xBF2350", Offset = "0xBF1750", VA = "0x180BF2350")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170018F4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6007229")]
				[Address(RVA = "0xBF22D0", Offset = "0xBF16D0", VA = "0x180BF22D0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170018F5")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x600722A")]
				[Address(RVA = "0xBF23A0", Offset = "0xBF17A0", VA = "0x180BF23A0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170018F6")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int CreatureFamily
			{
				[Token(Token = "0x600722E")]
				[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x600722F")]
				[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
				set
				{
				}
			}

			[Token(Token = "0x170018F7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int Count
			{
				[Token(Token = "0x6007230")]
				[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6007231")]
				[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
				set
				{
				}
			}

			[Token(Token = "0x600722B")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public MonsterCount()
			{
			}

			[Token(Token = "0x600722C")]
			[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public MonsterCount(MonsterCount other)
			{
			}

			[Token(Token = "0x600722D")]
			[Address(RVA = "0xBF2050", Offset = "0xBF1450", VA = "0x180BF2050", Slot = "10")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public MonsterCount Clone()
			{
				return null;
			}

			[Token(Token = "0x6007232")]
			[Address(RVA = "0xBF20E0", Offset = "0xBF14E0", VA = "0x180BF20E0", Slot = "0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6007233")]
			[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(MonsterCount other)
			{
				return default(bool);
			}

			[Token(Token = "0x6007234")]
			[Address(RVA = "0x9691C0", Offset = "0x9685C0", VA = "0x1809691C0", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6007235")]
			[Address(RVA = "0xBF2170", Offset = "0xBF1570", VA = "0x180BF2170", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6007236")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6007237")]
			[Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6007238")]
			[Address(RVA = "0xBF1F90", Offset = "0xBF1390", VA = "0x180BF1F90", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6007239")]
			[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(MonsterCount other)
			{
			}

			[Token(Token = "0x600723A")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x600723B")]
			[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}

		[Token(Token = "0x2000AE3")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class ObjectEffectMountValue : IMessage<ObjectEffectMountValue>, IMessage, IEquatable<ObjectEffectMountValue>, IDeepCloneable<ObjectEffectMountValue>, IBufferMessage
		{
			[Token(Token = "0x40027FF")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<ObjectEffectMountValue> _parser;

			[Token(Token = "0x4002800")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x4002801")]
			public const int CertificateIdFieldNumber = 1;

			[Token(Token = "0x4002802")]
			[FieldOffset(Offset = "0x18")]
			private long certificateId_;

			[Token(Token = "0x4002803")]
			public const int DateExpirationFieldNumber = 2;

			[Token(Token = "0x4002804")]
			[FieldOffset(Offset = "0x20")]
			private string dateExpiration_;

			[Token(Token = "0x4002805")]
			public const int ModelIdFieldNumber = 3;

			[Token(Token = "0x4002806")]
			[FieldOffset(Offset = "0x28")]
			private int modelId_;

			[Token(Token = "0x4002807")]
			public const int MountNameFieldNumber = 4;

			[Token(Token = "0x4002808")]
			[FieldOffset(Offset = "0x30")]
			private string mountName_;

			[Token(Token = "0x4002809")]
			public const int OwnerNameFieldNumber = 5;

			[Token(Token = "0x400280A")]
			[FieldOffset(Offset = "0x38")]
			private string ownerName_;

			[Token(Token = "0x400280B")]
			public const int MountLevelFieldNumber = 6;

			[Token(Token = "0x400280C")]
			[FieldOffset(Offset = "0x40")]
			private int mountLevel_;

			[Token(Token = "0x400280D")]
			public const int MountGenderFieldNumber = 7;

			[Token(Token = "0x400280E")]
			[FieldOffset(Offset = "0x44")]
			private Gender mountGender_;

			[Token(Token = "0x400280F")]
			public const int RideableFieldNumber = 8;

			[Token(Token = "0x4002810")]
			[FieldOffset(Offset = "0x48")]
			private bool rideable_;

			[Token(Token = "0x4002811")]
			public const int ImpregnatedFieldNumber = 9;

			[Token(Token = "0x4002812")]
			[FieldOffset(Offset = "0x49")]
			private bool impregnated_;

			[Token(Token = "0x4002813")]
			public const int ImpregnateReadyFieldNumber = 10;

			[Token(Token = "0x4002814")]
			[FieldOffset(Offset = "0x4A")]
			private bool impregnateReady_;

			[Token(Token = "0x4002815")]
			public const int ReproductionCountFieldNumber = 11;

			[Token(Token = "0x4002816")]
			[FieldOffset(Offset = "0x4C")]
			private int reproductionCount_;

			[Token(Token = "0x4002817")]
			public const int ReproductionMaxFieldNumber = 12;

			[Token(Token = "0x4002818")]
			[FieldOffset(Offset = "0x50")]
			private int reproductionMax_;

			[Token(Token = "0x4002819")]
			public const int EffectFieldNumber = 13;

			[Token(Token = "0x400281A")]
			[FieldOffset(Offset = "0x8")]
			private static readonly FieldCodec<ObjectEffect> _repeated_effect_codec;

			[Token(Token = "0x400281B")]
			[FieldOffset(Offset = "0x58")]
			private readonly RepeatedField<ObjectEffect> effect_;

			[Token(Token = "0x400281C")]
			public const int CapacityFieldNumber = 14;

			[Token(Token = "0x400281D")]
			[FieldOffset(Offset = "0x10")]
			private static readonly FieldCodec<int> _repeated_capacity_codec;

			[Token(Token = "0x400281E")]
			[FieldOffset(Offset = "0x60")]
			private readonly RepeatedField<int> capacity_;

			[Token(Token = "0x170018F8")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageParser<ObjectEffectMountValue> Parser
			{
				[Token(Token = "0x6007240")]
				[Address(RVA = "0xBF3E20", Offset = "0xBF3220", VA = "0x180BF3E20")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170018F9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6007241")]
				[Address(RVA = "0xBF3D80", Offset = "0xBF3180", VA = "0x180BF3D80")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170018FA")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6007242")]
				[Address(RVA = "0xBF4490", Offset = "0xBF3890", VA = "0x180BF4490", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170018FB")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public long CertificateId
			{
				[Token(Token = "0x6007246")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x6007247")]
				[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
				set
				{
				}
			}

			[Token(Token = "0x170018FC")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public string DateExpiration
			{
				[Token(Token = "0x6007248")]
				[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
				get
				{
					return null;
				}
				[Token(Token = "0x6007249")]
				[Address(RVA = "0xBF4540", Offset = "0xBF3940", VA = "0x180BF4540")]
				set
				{
				}
			}

			[Token(Token = "0x170018FD")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int ModelId
			{
				[Token(Token = "0x600724A")]
				[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x600724B")]
				[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
				set
				{
				}
			}

			[Token(Token = "0x170018FE")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public string MountName
			{
				[Token(Token = "0x600724C")]
				[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
				get
				{
					return null;
				}
				[Token(Token = "0x600724D")]
				[Address(RVA = "0xBF45D0", Offset = "0xBF39D0", VA = "0x180BF45D0")]
				set
				{
				}
			}

			[Token(Token = "0x170018FF")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public string OwnerName
			{
				[Token(Token = "0x600724E")]
				[Address(RVA = "0x87D8A0", Offset = "0x87CCA0", VA = "0x18087D8A0")]
				get
				{
					return null;
				}
				[Token(Token = "0x600724F")]
				[Address(RVA = "0xBF4640", Offset = "0xBF3A40", VA = "0x180BF4640")]
				set
				{
				}
			}

			[Token(Token = "0x17001900")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int MountLevel
			{
				[Token(Token = "0x6007250")]
				[Address(RVA = "0x95FB30", Offset = "0x95EF30", VA = "0x18095FB30")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6007251")]
				[Address(RVA = "0x9F30F0", Offset = "0x9F24F0", VA = "0x1809F30F0")]
				set
				{
				}
			}

			[Token(Token = "0x17001901")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Gender MountGender
			{
				[Token(Token = "0x6007252")]
				[Address(RVA = "0x7D9DB0", Offset = "0x7D91B0", VA = "0x1807D9DB0")]
				get
				{
					return default(Gender);
				}
				[Token(Token = "0x6007253")]
				[Address(RVA = "0x9F3100", Offset = "0x9F2500", VA = "0x1809F3100")]
				set
				{
				}
			}

			[Token(Token = "0x17001902")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Rideable
			{
				[Token(Token = "0x6007254")]
				[Address(RVA = "0x8B06C0", Offset = "0x8AFAC0", VA = "0x1808B06C0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6007255")]
				[Address(RVA = "0xBF46C0", Offset = "0xBF3AC0", VA = "0x180BF46C0")]
				set
				{
				}
			}

			[Token(Token = "0x17001903")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool Impregnated
			{
				[Token(Token = "0x6007256")]
				[Address(RVA = "0xBF3E10", Offset = "0xBF3210", VA = "0x180BF3E10")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6007257")]
				[Address(RVA = "0xBF45C0", Offset = "0xBF39C0", VA = "0x180BF45C0")]
				set
				{
				}
			}

			[Token(Token = "0x17001904")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool ImpregnateReady
			{
				[Token(Token = "0x6007258")]
				[Address(RVA = "0xBF3E00", Offset = "0xBF3200", VA = "0x180BF3E00")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6007259")]
				[Address(RVA = "0xBF45B0", Offset = "0xBF39B0", VA = "0x180BF45B0")]
				set
				{
				}
			}

			[Token(Token = "0x17001905")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int ReproductionCount
			{
				[Token(Token = "0x600725A")]
				[Address(RVA = "0xBF3E70", Offset = "0xBF3270", VA = "0x180BF3E70")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x600725B")]
				[Address(RVA = "0xBF46B0", Offset = "0xBF3AB0", VA = "0x180BF46B0")]
				set
				{
				}
			}

			[Token(Token = "0x17001906")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int ReproductionMax
			{
				[Token(Token = "0x600725C")]
				[Address(RVA = "0x874EA0", Offset = "0x8742A0", VA = "0x180874EA0")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x600725D")]
				[Address(RVA = "0x874F70", Offset = "0x874370", VA = "0x180874F70")]
				set
				{
				}
			}

			[Token(Token = "0x17001907")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public RepeatedField<ObjectEffect> Effect
			{
				[Token(Token = "0x600725E")]
				[Address(RVA = "0x9124F0", Offset = "0x9118F0", VA = "0x1809124F0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001908")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public RepeatedField<int> Capacity
			{
				[Token(Token = "0x600725F")]
				[Address(RVA = "0x7D7250", Offset = "0x7D6650", VA = "0x1807D7250")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6007243")]
			[Address(RVA = "0xBF3C60", Offset = "0xBF3060", VA = "0x180BF3C60")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public ObjectEffectMountValue()
			{
			}

			[Token(Token = "0x6007244")]
			[Address(RVA = "0xBF3B30", Offset = "0xBF2F30", VA = "0x180BF3B30")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public ObjectEffectMountValue(ObjectEffectMountValue other)
			{
			}

			[Token(Token = "0x6007245")]
			[Address(RVA = "0xBF30B0", Offset = "0xBF24B0", VA = "0x180BF30B0", Slot = "10")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public ObjectEffectMountValue Clone()
			{
				return null;
			}

			[Token(Token = "0x6007260")]
			[Address(RVA = "0xBF3380", Offset = "0xBF2780", VA = "0x180BF3380", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6007261")]
			[Address(RVA = "0xBF3210", Offset = "0xBF2610", VA = "0x180BF3210", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(ObjectEffectMountValue other)
			{
				return default(bool);
			}

			[Token(Token = "0x6007262")]
			[Address(RVA = "0xBF3530", Offset = "0xBF2930", VA = "0x180BF3530", Slot = "2")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6007263")]
			[Address(RVA = "0xBF38F0", Offset = "0xBF2CF0", VA = "0x180BF38F0", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6007264")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6007265")]
			[Address(RVA = "0xBF41F0", Offset = "0xBF35F0", VA = "0x180BF41F0", Slot = "12")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6007266")]
			[Address(RVA = "0xBF2E00", Offset = "0xBF2200", VA = "0x180BF2E00", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6007267")]
			[Address(RVA = "0xBF3790", Offset = "0xBF2B90", VA = "0x180BF3790", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(ObjectEffectMountValue other)
			{
			}

			[Token(Token = "0x6007268")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6007269")]
			[Address(RVA = "0xBF3E80", Offset = "0xBF3280", VA = "0x180BF3E80", Slot = "11")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x40027C1")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ObjectEffect> _parser;

	[Token(Token = "0x40027C2")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40027C3")]
	public const int ActionFieldNumber = 1;

	[Token(Token = "0x40027C4")]
	[FieldOffset(Offset = "0x18")]
	private int action_;

	[Token(Token = "0x40027C5")]
	public const int ValueStringFieldNumber = 2;

	[Token(Token = "0x40027C6")]
	public const int ValueIntFieldNumber = 3;

	[Token(Token = "0x40027C7")]
	public const int MinMaxFieldNumber = 4;

	[Token(Token = "0x40027C8")]
	public const int DiceFieldNumber = 5;

	[Token(Token = "0x40027C9")]
	public const int DateFieldNumber = 6;

	[Token(Token = "0x40027CA")]
	public const int DurationMinuteFieldNumber = 7;

	[Token(Token = "0x40027CB")]
	public const int CreatureFamilyFieldNumber = 8;

	[Token(Token = "0x40027CC")]
	public const int MonsterCountFieldNumber = 9;

	[Token(Token = "0x40027CD")]
	public const int MountFieldNumber = 10;

	[Token(Token = "0x40027CE")]
	[FieldOffset(Offset = "0x20")]
	private object effect_;

	[Token(Token = "0x40027CF")]
	[FieldOffset(Offset = "0x28")]
	private EffectOneofCase effectCase_;

	[Token(Token = "0x170018CE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ObjectEffect> Parser
	{
		[Token(Token = "0x60071A9")]
		[Address(RVA = "0xBF60C0", Offset = "0xBF54C0", VA = "0x180BF60C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170018CF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60071AA")]
		[Address(RVA = "0xBF5E00", Offset = "0xBF5200", VA = "0x180BF5E00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170018D0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60071AB")]
		[Address(RVA = "0xBF6B10", Offset = "0xBF5F10", VA = "0x180BF6B10", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170018D1")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Action
	{
		[Token(Token = "0x60071AF")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60071B0")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170018D2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string ValueString
	{
		[Token(Token = "0x60071B1")]
		[Address(RVA = "0xBF6180", Offset = "0xBF5580", VA = "0x180BF6180")]
		get
		{
			return null;
		}
		[Token(Token = "0x60071B2")]
		[Address(RVA = "0xBF6D20", Offset = "0xBF6120", VA = "0x180BF6D20")]
		set
		{
		}
	}

	[Token(Token = "0x170018D3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool HasValueString
	{
		[Token(Token = "0x60071B3")]
		[Address(RVA = "0xA51710", Offset = "0xA50B10", VA = "0x180A51710")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170018D4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ValueInt
	{
		[Token(Token = "0x60071B5")]
		[Address(RVA = "0xBF6110", Offset = "0xBF5510", VA = "0x180BF6110")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60071B6")]
		[Address(RVA = "0xBF6CB0", Offset = "0xBF60B0", VA = "0x180BF6CB0")]
		set
		{
		}
	}

	[Token(Token = "0x170018D5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool HasValueInt
	{
		[Token(Token = "0x60071B7")]
		[Address(RVA = "0xA51720", Offset = "0xA50B20", VA = "0x180A51720")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170018D6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.ObjectEffectMinMaxValue MinMax
	{
		[Token(Token = "0x60071B9")]
		[Address(RVA = "0xBF5FA0", Offset = "0xBF53A0", VA = "0x180BF5FA0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60071BA")]
		[Address(RVA = "0x926610", Offset = "0x925A10", VA = "0x180926610")]
		set
		{
		}
	}

	[Token(Token = "0x170018D7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.ObjectEffectDiceValue Dice
	{
		[Token(Token = "0x60071BB")]
		[Address(RVA = "0xBF5EB0", Offset = "0xBF52B0", VA = "0x180BF5EB0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60071BC")]
		[Address(RVA = "0x9264D0", Offset = "0x9258D0", VA = "0x1809264D0")]
		set
		{
		}
	}

	[Token(Token = "0x170018D8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.DofusDate Date
	{
		[Token(Token = "0x60071BD")]
		[Address(RVA = "0xBF5DA0", Offset = "0xBF51A0", VA = "0x180BF5DA0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60071BE")]
		[Address(RVA = "0x9265D0", Offset = "0x9259D0", VA = "0x1809265D0")]
		set
		{
		}
	}

	[Token(Token = "0x170018D9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long DurationMinute
	{
		[Token(Token = "0x60071BF")]
		[Address(RVA = "0xBF5F10", Offset = "0xBF5310", VA = "0x180BF5F10")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60071C0")]
		[Address(RVA = "0xBF6BC0", Offset = "0xBF5FC0", VA = "0x180BF6BC0")]
		set
		{
		}
	}

	[Token(Token = "0x170018DA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasDurationMinute
	{
		[Token(Token = "0x60071C1")]
		[Address(RVA = "0xBF5F90", Offset = "0xBF5390", VA = "0x180BF5F90")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170018DB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CreatureFamily
	{
		[Token(Token = "0x60071C3")]
		[Address(RVA = "0xBF5D30", Offset = "0xBF5130", VA = "0x180BF5D30")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60071C4")]
		[Address(RVA = "0xBF6B50", Offset = "0xBF5F50", VA = "0x180BF6B50")]
		set
		{
		}
	}

	[Token(Token = "0x170018DC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool HasCreatureFamily
	{
		[Token(Token = "0x60071C5")]
		[Address(RVA = "0xBF5F80", Offset = "0xBF5380", VA = "0x180BF5F80")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170018DD")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.MonsterCount MonsterCount
	{
		[Token(Token = "0x60071C7")]
		[Address(RVA = "0xBF6000", Offset = "0xBF5400", VA = "0x180BF6000")]
		get
		{
			return null;
		}
		[Token(Token = "0x60071C8")]
		[Address(RVA = "0xBF6C30", Offset = "0xBF6030", VA = "0x180BF6C30")]
		set
		{
		}
	}

	[Token(Token = "0x170018DE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.ObjectEffectMountValue Mount
	{
		[Token(Token = "0x60071C9")]
		[Address(RVA = "0xBF6060", Offset = "0xBF5460", VA = "0x180BF6060")]
		get
		{
			return null;
		}
		[Token(Token = "0x60071CA")]
		[Address(RVA = "0xBF6C70", Offset = "0xBF6070", VA = "0x180BF6C70")]
		set
		{
		}
	}

	[Token(Token = "0x170018DF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EffectOneofCase EffectCase
	{
		[Token(Token = "0x60071CB")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(EffectOneofCase);
		}
	}

	[Token(Token = "0x60071AC")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectEffect()
	{
	}

	[Token(Token = "0x60071AD")]
	[Address(RVA = "0xBF5860", Offset = "0xBF4C60", VA = "0x180BF5860")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectEffect(ObjectEffect other)
	{
	}

	[Token(Token = "0x60071AE")]
	[Address(RVA = "0xBF4BF0", Offset = "0xBF3FF0", VA = "0x180BF4BF0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectEffect Clone()
	{
		return null;
	}

	[Token(Token = "0x60071B4")]
	[Address(RVA = "0xA50F20", Offset = "0xA50320", VA = "0x180A50F20")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearValueString()
	{
	}

	[Token(Token = "0x60071B8")]
	[Address(RVA = "0xA50F40", Offset = "0xA50340", VA = "0x180A50F40")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearValueInt()
	{
	}

	[Token(Token = "0x60071C2")]
	[Address(RVA = "0xBF4BD0", Offset = "0xBF3FD0", VA = "0x180BF4BD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearDurationMinute()
	{
	}

	[Token(Token = "0x60071C6")]
	[Address(RVA = "0xBF4BB0", Offset = "0xBF3FB0", VA = "0x180BF4BB0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearCreatureFamily()
	{
	}

	[Token(Token = "0x60071CC")]
	[Address(RVA = "0x9247A0", Offset = "0x923BA0", VA = "0x1809247A0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearEffect()
	{
	}

	[Token(Token = "0x60071CD")]
	[Address(RVA = "0xBF4C50", Offset = "0xBF4050", VA = "0x180BF4C50", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60071CE")]
	[Address(RVA = "0xBF4CB0", Offset = "0xBF40B0", VA = "0x180BF4CB0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ObjectEffect other)
	{
		return default(bool);
	}

	[Token(Token = "0x60071CF")]
	[Address(RVA = "0xBF4E90", Offset = "0xBF4290", VA = "0x180BF4E90", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60071D0")]
	[Address(RVA = "0xBF5700", Offset = "0xBF4B00", VA = "0x180BF5700", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60071D1")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60071D2")]
	[Address(RVA = "0xBF66A0", Offset = "0xBF5AA0", VA = "0x180BF66A0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60071D3")]
	[Address(RVA = "0xBF46D0", Offset = "0xBF3AD0", VA = "0x180BF46D0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60071D4")]
	[Address(RVA = "0xBF5320", Offset = "0xBF4720", VA = "0x180BF5320", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ObjectEffect other)
	{
	}

	[Token(Token = "0x60071D5")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60071D6")]
	[Address(RVA = "0xBF61F0", Offset = "0xBF55F0", VA = "0x180BF61F0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
