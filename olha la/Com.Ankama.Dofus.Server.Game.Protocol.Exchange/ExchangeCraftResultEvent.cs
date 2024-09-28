using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x20006DD")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeCraftResultEvent : IMessage<ExchangeCraftResultEvent>, IMessage, IEquatable<ExchangeCraftResultEvent>, IDeepCloneable<ExchangeCraftResultEvent>, IBufferMessage
{
	[Token(Token = "0x20006DE")]
	public enum ComplementOneofCase
	{
		[Token(Token = "0x4001829")]
		None = 0,
		[Token(Token = "0x400182A")]
		ObjectGid = 2,
		[Token(Token = "0x400182B")]
		Object = 3
	}

	[Token(Token = "0x20006DF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x20006E0")]
		public enum CraftResult
		{
			[Token(Token = "0x400182D")]
			[OriginalName("IMPOSSIBLE")]
			Impossible,
			[Token(Token = "0x400182E")]
			[OriginalName("FAILED")]
			Failed,
			[Token(Token = "0x400182F")]
			[OriginalName("SUCCESS")]
			Success,
			[Token(Token = "0x4001830")]
			[OriginalName("NEUTRAL")]
			Neutral,
			[Token(Token = "0x4001831")]
			[OriginalName("FORBIDDEN")]
			Forbidden
		}

		[Token(Token = "0x20006E1")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class ExchangeCraftResultWithObjectDescription : IMessage<ExchangeCraftResultWithObjectDescription>, IMessage, IEquatable<ExchangeCraftResultWithObjectDescription>, IDeepCloneable<ExchangeCraftResultWithObjectDescription>, IBufferMessage
		{
			[Token(Token = "0x20006E2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static class Types
			{
				[Token(Token = "0x20006E3")]
				public enum MagicPoolStatus
				{
					[Token(Token = "0x400183D")]
					[OriginalName("NO_CHANGE")]
					NoChange,
					[Token(Token = "0x400183E")]
					[OriginalName("INCREASE")]
					Increase,
					[Token(Token = "0x400183F")]
					[OriginalName("LOSS")]
					Loss
				}
			}

			[Token(Token = "0x4001832")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<ExchangeCraftResultWithObjectDescription> _parser;

			[Token(Token = "0x4001833")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x4001834")]
			[FieldOffset(Offset = "0x18")]
			private int _hasBits0;

			[Token(Token = "0x4001835")]
			public const int ObjectFieldNumber = 1;

			[Token(Token = "0x4001836")]
			[FieldOffset(Offset = "0x20")]
			private ObjectItem object_;

			[Token(Token = "0x4001837")]
			public const int MagicPoolStatusFieldNumber = 2;

			[Token(Token = "0x4001838")]
			[FieldOffset(Offset = "0x8")]
			private static readonly Types.MagicPoolStatus MagicPoolStatusDefaultValue;

			[Token(Token = "0x4001839")]
			[FieldOffset(Offset = "0x28")]
			private Types.MagicPoolStatus magicPoolStatus_;

			[Token(Token = "0x400183A")]
			public const int FmPowerFieldNumber = 3;

			[Token(Token = "0x400183B")]
			[FieldOffset(Offset = "0x2C")]
			private float fmPower_;

			[Token(Token = "0x17000FD3")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<ExchangeCraftResultWithObjectDescription> Parser
			{
				[Token(Token = "0x60049FB")]
				[Address(RVA = "0xAA6C50", Offset = "0xAA6050", VA = "0x180AA6C50")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000FD4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x60049FC")]
				[Address(RVA = "0xAA6B50", Offset = "0xAA5F50", VA = "0x180AA6B50")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000FD5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x60049FD")]
				[Address(RVA = "0xAA6ED0", Offset = "0xAA62D0", VA = "0x180AA6ED0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000FD6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public ObjectItem Object
			{
				[Token(Token = "0x6004A01")]
				[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
				get
				{
					return null;
				}
				[Token(Token = "0x6004A02")]
				[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
				set
				{
				}
			}

			[Token(Token = "0x17000FD7")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public Types.MagicPoolStatus MagicPoolStatus
			{
				[Token(Token = "0x6004A03")]
				[Address(RVA = "0xAA6BE0", Offset = "0xAA5FE0", VA = "0x180AA6BE0")]
				get
				{
					return default(Types.MagicPoolStatus);
				}
				[Token(Token = "0x6004A04")]
				[Address(RVA = "0xA0A2B0", Offset = "0xA096B0", VA = "0x180A0A2B0")]
				set
				{
				}
			}

			[Token(Token = "0x17000FD8")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool HasMagicPoolStatus
			{
				[Token(Token = "0x6004A05")]
				[Address(RVA = "0x87E8D0", Offset = "0x87DCD0", VA = "0x18087E8D0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000FD9")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public float FmPower
			{
				[Token(Token = "0x6004A07")]
				[Address(RVA = "0xAA6BD0", Offset = "0xAA5FD0", VA = "0x180AA6BD0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6004A08")]
				[Address(RVA = "0xAA6F80", Offset = "0xAA6380", VA = "0x180AA6F80")]
				set
				{
				}
			}

			[Token(Token = "0x60049FE")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public ExchangeCraftResultWithObjectDescription()
			{
			}

			[Token(Token = "0x60049FF")]
			[Address(RVA = "0xAA6AD0", Offset = "0xAA5ED0", VA = "0x180AA6AD0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public ExchangeCraftResultWithObjectDescription(ExchangeCraftResultWithObjectDescription other)
			{
			}

			[Token(Token = "0x6004A00")]
			[Address(RVA = "0xAA63F0", Offset = "0xAA57F0", VA = "0x180AA63F0", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public ExchangeCraftResultWithObjectDescription Clone()
			{
				return null;
			}

			[Token(Token = "0x6004A06")]
			[Address(RVA = "0x92D290", Offset = "0x92C690", VA = "0x18092D290")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void ClearMagicPoolStatus()
			{
			}

			[Token(Token = "0x6004A09")]
			[Address(RVA = "0xAA65A0", Offset = "0xAA59A0", VA = "0x180AA65A0", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6004A0A")]
			[Address(RVA = "0xAA64A0", Offset = "0xAA58A0", VA = "0x180AA64A0", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(ExchangeCraftResultWithObjectDescription other)
			{
				return default(bool);
			}

			[Token(Token = "0x6004A0B")]
			[Address(RVA = "0xAA66E0", Offset = "0xAA5AE0", VA = "0x180AA66E0", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6004A0C")]
			[Address(RVA = "0xAA6960", Offset = "0xAA5D60", VA = "0x180AA6960", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6004A0D")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6004A0E")]
			[Address(RVA = "0xAA6DE0", Offset = "0xAA61E0", VA = "0x180AA6DE0", Slot = "12")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6004A0F")]
			[Address(RVA = "0xAA62D0", Offset = "0xAA56D0", VA = "0x180AA62D0", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6004A10")]
			[Address(RVA = "0xAA6860", Offset = "0xAA5C60", VA = "0x180AA6860", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(ExchangeCraftResultWithObjectDescription other)
			{
			}

			[Token(Token = "0x6004A11")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6004A12")]
			[Address(RVA = "0xAA6CA0", Offset = "0xAA60A0", VA = "0x180AA6CA0", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x4001820")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeCraftResultEvent> _parser;

	[Token(Token = "0x4001821")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001822")]
	public const int ResultFieldNumber = 1;

	[Token(Token = "0x4001823")]
	[FieldOffset(Offset = "0x18")]
	private Types.CraftResult result_;

	[Token(Token = "0x4001824")]
	public const int ObjectGidFieldNumber = 2;

	[Token(Token = "0x4001825")]
	public const int ObjectFieldNumber = 3;

	[Token(Token = "0x4001826")]
	[FieldOffset(Offset = "0x20")]
	private object complement_;

	[Token(Token = "0x4001827")]
	[FieldOffset(Offset = "0x28")]
	private ComplementOneofCase complementCase_;

	[Token(Token = "0x17000FCB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ExchangeCraftResultEvent> Parser
	{
		[Token(Token = "0x60049E0")]
		[Address(RVA = "0xAA5F30", Offset = "0xAA5330", VA = "0x180AA5F30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000FCC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60049E1")]
		[Address(RVA = "0xAA5DB0", Offset = "0xAA51B0", VA = "0x180AA5DB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000FCD")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60049E2")]
		[Address(RVA = "0xAA6220", Offset = "0xAA5620", VA = "0x180AA6220", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000FCE")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.CraftResult Result
	{
		[Token(Token = "0x60049E6")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(Types.CraftResult);
		}
		[Token(Token = "0x60049E7")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000FCF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ObjectGid
	{
		[Token(Token = "0x60049E8")]
		[Address(RVA = "0xAA5E60", Offset = "0xAA5260", VA = "0x180AA5E60")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60049E9")]
		[Address(RVA = "0xAA6260", Offset = "0xAA5660", VA = "0x180AA6260")]
		set
		{
		}
	}

	[Token(Token = "0x17000FD0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool HasObjectGid
	{
		[Token(Token = "0x60049EA")]
		[Address(RVA = "0xA51710", Offset = "0xA50B10", VA = "0x180A51710")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000FD1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.ExchangeCraftResultWithObjectDescription Object
	{
		[Token(Token = "0x60049EC")]
		[Address(RVA = "0xAA5ED0", Offset = "0xAA52D0", VA = "0x180AA5ED0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60049ED")]
		[Address(RVA = "0x926550", Offset = "0x925950", VA = "0x180926550")]
		set
		{
		}
	}

	[Token(Token = "0x17000FD2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ComplementOneofCase ComplementCase
	{
		[Token(Token = "0x60049EE")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(ComplementOneofCase);
		}
	}

	[Token(Token = "0x60049E3")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeCraftResultEvent()
	{
	}

	[Token(Token = "0x60049E4")]
	[Address(RVA = "0xAA5BF0", Offset = "0xAA4FF0", VA = "0x180AA5BF0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeCraftResultEvent(ExchangeCraftResultEvent other)
	{
	}

	[Token(Token = "0x60049E5")]
	[Address(RVA = "0xAA5620", Offset = "0xAA4A20", VA = "0x180AA5620", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeCraftResultEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60049EB")]
	[Address(RVA = "0xA50F20", Offset = "0xA50320", VA = "0x180A50F20")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearObjectGid()
	{
	}

	[Token(Token = "0x60049EF")]
	[Address(RVA = "0x9247A0", Offset = "0x923BA0", VA = "0x1809247A0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearComplement()
	{
	}

	[Token(Token = "0x60049F0")]
	[Address(RVA = "0xAA5680", Offset = "0xAA4A80", VA = "0x180AA5680", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60049F1")]
	[Address(RVA = "0xAA5770", Offset = "0xAA4B70", VA = "0x180AA5770", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ExchangeCraftResultEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60049F2")]
	[Address(RVA = "0xAA5830", Offset = "0xAA4C30", VA = "0x180AA5830", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60049F3")]
	[Address(RVA = "0xAA5A90", Offset = "0xAA4E90", VA = "0x180AA5A90", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60049F4")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60049F5")]
	[Address(RVA = "0xAA60E0", Offset = "0xAA54E0", VA = "0x180AA60E0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60049F6")]
	[Address(RVA = "0xAA54A0", Offset = "0xAA48A0", VA = "0x180AA54A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60049F7")]
	[Address(RVA = "0xAA5980", Offset = "0xAA4D80", VA = "0x180AA5980", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeCraftResultEvent other)
	{
	}

	[Token(Token = "0x60049F8")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60049F9")]
	[Address(RVA = "0xAA5F80", Offset = "0xAA5380", VA = "0x180AA5F80", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
