using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset;

[Token(Token = "0x20001F2")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ForgettableSpellPresetCreateResponse : IMessage<ForgettableSpellPresetCreateResponse>, IMessage, IEquatable<ForgettableSpellPresetCreateResponse>, IDeepCloneable<ForgettableSpellPresetCreateResponse>, IBufferMessage
{
	[Token(Token = "0x20001F3")]
	public enum ResultOneofCase
	{
		[Token(Token = "0x40006A6")]
		None,
		[Token(Token = "0x40006A7")]
		Success,
		[Token(Token = "0x40006A8")]
		Error
	}

	[Token(Token = "0x20001F4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x20001F5")]
		public enum Error
		{
			[Token(Token = "0x40006AA")]
			[OriginalName("FEATURE_DISABLED")]
			FeatureDisabled,
			[Token(Token = "0x40006AB")]
			[OriginalName("MAX_QUANTITY")]
			MaxQuantity,
			[Token(Token = "0x40006AC")]
			[OriginalName("INVALID_NAME_SIZE")]
			InvalidNameSize,
			[Token(Token = "0x40006AD")]
			[OriginalName("PRESET_NOT_FOUND")]
			PresetNotFound,
			[Token(Token = "0x40006AE")]
			[OriginalName("UNKNOWN")]
			Unknown
		}

		[Token(Token = "0x20001F6")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class Success : IMessage<Success>, IMessage, IEquatable<Success>, IDeepCloneable<Success>, IBufferMessage
		{
			[Token(Token = "0x40006AF")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<Success> _parser;

			[Token(Token = "0x40006B0")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x40006B1")]
			public const int PresetInfoFieldNumber = 1;

			[Token(Token = "0x40006B2")]
			[FieldOffset(Offset = "0x18")]
			private ForgettableSpellPresetInfo presetInfo_;

			[Token(Token = "0x17000444")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageParser<Success> Parser
			{
				[Token(Token = "0x60013E4")]
				[Address(RVA = "0xCED330", Offset = "0xCEC730", VA = "0x180CED330")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000445")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x60013E5")]
				[Address(RVA = "0xCED1E0", Offset = "0xCEC5E0", VA = "0x180CED1E0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000446")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x60013E6")]
				[Address(RVA = "0xCED630", Offset = "0xCECA30", VA = "0x180CED630", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000447")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public ForgettableSpellPresetInfo PresetInfo
			{
				[Token(Token = "0x60013EA")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return null;
				}
				[Token(Token = "0x60013EB")]
				[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
				set
				{
				}
			}

			[Token(Token = "0x60013E7")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Success()
			{
			}

			[Token(Token = "0x60013E8")]
			[Address(RVA = "0xCED100", Offset = "0xCEC500", VA = "0x180CED100")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Success(Success other)
			{
			}

			[Token(Token = "0x60013E9")]
			[Address(RVA = "0xCECAA0", Offset = "0xCEBEA0", VA = "0x180CECAA0", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Success Clone()
			{
				return null;
			}

			[Token(Token = "0x60013EC")]
			[Address(RVA = "0xCECB40", Offset = "0xCEBF40", VA = "0x180CECB40", Slot = "0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x60013ED")]
			[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool Equals(Success other)
			{
				return default(bool);
			}

			[Token(Token = "0x60013EE")]
			[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x60013EF")]
			[Address(RVA = "0xCECE40", Offset = "0xCEC240", VA = "0x180CECE40", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x60013F0")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x60013F1")]
			[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x60013F2")]
			[Address(RVA = "0xCEC970", Offset = "0xCEBD70", VA = "0x180CEC970", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x60013F3")]
			[Address(RVA = "0xCECCA0", Offset = "0xCEC0A0", VA = "0x180CECCA0", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(Success other)
			{
			}

			[Token(Token = "0x60013F4")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x60013F5")]
			[Address(RVA = "0xCED480", Offset = "0xCEC880", VA = "0x180CED480", Slot = "11")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x400069F")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ForgettableSpellPresetCreateResponse> _parser;

	[Token(Token = "0x40006A0")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40006A1")]
	public const int SuccessFieldNumber = 1;

	[Token(Token = "0x40006A2")]
	public const int ErrorFieldNumber = 2;

	[Token(Token = "0x40006A3")]
	[FieldOffset(Offset = "0x18")]
	private object result_;

	[Token(Token = "0x40006A4")]
	[FieldOffset(Offset = "0x20")]
	private ResultOneofCase resultCase_;

	[Token(Token = "0x1700043D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ForgettableSpellPresetCreateResponse> Parser
	{
		[Token(Token = "0x60013CB")]
		[Address(RVA = "0xCDE4D0", Offset = "0xCDD8D0", VA = "0x180CDE4D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700043E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60013CC")]
		[Address(RVA = "0xCDE3B0", Offset = "0xCDD7B0", VA = "0x180CDE3B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700043F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60013CD")]
		[Address(RVA = "0xCDE810", Offset = "0xCDDC10", VA = "0x180CDE810", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000440")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.Success Success
	{
		[Token(Token = "0x60013D1")]
		[Address(RVA = "0xCDE520", Offset = "0xCDD920", VA = "0x180CDE520")]
		get
		{
			return null;
		}
		[Token(Token = "0x60013D2")]
		[Address(RVA = "0x917DA0", Offset = "0x9171A0", VA = "0x180917DA0")]
		set
		{
		}
	}

	[Token(Token = "0x17000441")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.Error Error
	{
		[Token(Token = "0x60013D3")]
		[Address(RVA = "0xCDE460", Offset = "0xCDD860", VA = "0x180CDE460")]
		get
		{
			return default(Types.Error);
		}
		[Token(Token = "0x60013D4")]
		[Address(RVA = "0xCDE850", Offset = "0xCDDC50", VA = "0x180CDE850")]
		set
		{
		}
	}

	[Token(Token = "0x17000442")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasError
	{
		[Token(Token = "0x60013D5")]
		[Address(RVA = "0x92A010", Offset = "0x929410", VA = "0x18092A010")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000443")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ResultOneofCase ResultCase
	{
		[Token(Token = "0x60013D7")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(ResultOneofCase);
		}
	}

	[Token(Token = "0x60013CE")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ForgettableSpellPresetCreateResponse()
	{
	}

	[Token(Token = "0x60013CF")]
	[Address(RVA = "0xCDE230", Offset = "0xCDD630", VA = "0x180CDE230")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ForgettableSpellPresetCreateResponse(ForgettableSpellPresetCreateResponse other)
	{
	}

	[Token(Token = "0x60013D0")]
	[Address(RVA = "0xCDD980", Offset = "0xCDCD80", VA = "0x180CDD980", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ForgettableSpellPresetCreateResponse Clone()
	{
		return null;
	}

	[Token(Token = "0x60013D6")]
	[Address(RVA = "0x9295C0", Offset = "0x9289C0", VA = "0x1809295C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearError()
	{
	}

	[Token(Token = "0x60013D8")]
	[Address(RVA = "0x916DD0", Offset = "0x9161D0", VA = "0x180916DD0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void ClearResult()
	{
	}

	[Token(Token = "0x60013D9")]
	[Address(RVA = "0xCDDC50", Offset = "0xCDD050", VA = "0x180CDDC50", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60013DA")]
	[Address(RVA = "0xCDDB30", Offset = "0xCDCF30", VA = "0x180CDDB30", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ForgettableSpellPresetCreateResponse other)
	{
		return default(bool);
	}

	[Token(Token = "0x60013DB")]
	[Address(RVA = "0xCDDDB0", Offset = "0xCDD1B0", VA = "0x180CDDDB0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60013DC")]
	[Address(RVA = "0xCDE0D0", Offset = "0xCDD4D0", VA = "0x180CDE0D0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60013DD")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60013DE")]
	[Address(RVA = "0xCDE6F0", Offset = "0xCDDAF0", VA = "0x180CDE6F0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60013DF")]
	[Address(RVA = "0xCDD830", Offset = "0xCDCC30", VA = "0x180CDD830", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60013E0")]
	[Address(RVA = "0xCDDEE0", Offset = "0xCDD2E0", VA = "0x180CDDEE0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ForgettableSpellPresetCreateResponse other)
	{
	}

	[Token(Token = "0x60013E1")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60013E2")]
	[Address(RVA = "0xCDE580", Offset = "0xCDD980", VA = "0x180CDE580", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
