using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset;

[Token(Token = "0x20001E9")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CharacterPresetCreateResponse : IMessage<CharacterPresetCreateResponse>, IMessage, IEquatable<CharacterPresetCreateResponse>, IDeepCloneable<CharacterPresetCreateResponse>, IBufferMessage
{
	[Token(Token = "0x20001EA")]
	public enum ResultOneofCase
	{
		[Token(Token = "0x4000688")]
		None,
		[Token(Token = "0x4000689")]
		Success,
		[Token(Token = "0x400068A")]
		Error
	}

	[Token(Token = "0x20001EB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x20001EC")]
		public enum Error
		{
			[Token(Token = "0x400068C")]
			[OriginalName("MAX_QUANTITY")]
			MaxQuantity,
			[Token(Token = "0x400068D")]
			[OriginalName("INVALID_NAME_SIZE")]
			InvalidNameSize,
			[Token(Token = "0x400068E")]
			[OriginalName("PRESET_NOT_FOUND")]
			PresetNotFound,
			[Token(Token = "0x400068F")]
			[OriginalName("UNKNOWN")]
			Unknown
		}

		[Token(Token = "0x20001ED")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class Success : IMessage<Success>, IMessage, IEquatable<Success>, IDeepCloneable<Success>, IBufferMessage
		{
			[Token(Token = "0x4000690")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<Success> _parser;

			[Token(Token = "0x4000691")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x4000692")]
			public const int PresetInfoFieldNumber = 1;

			[Token(Token = "0x4000693")]
			[FieldOffset(Offset = "0x18")]
			private CharacterPresetInfo presetInfo_;

			[Token(Token = "0x17000433")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageParser<Success> Parser
			{
				[Token(Token = "0x6001398")]
				[Address(RVA = "0xCED2E0", Offset = "0xCEC6E0", VA = "0x180CED2E0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000434")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6001399")]
				[Address(RVA = "0xCED260", Offset = "0xCEC660", VA = "0x180CED260")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000435")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x600139A")]
				[Address(RVA = "0xCED580", Offset = "0xCEC980", VA = "0x180CED580", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000436")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public CharacterPresetInfo PresetInfo
			{
				[Token(Token = "0x600139E")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return null;
				}
				[Token(Token = "0x600139F")]
				[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
				set
				{
				}
			}

			[Token(Token = "0x600139B")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Success()
			{
			}

			[Token(Token = "0x600139C")]
			[Address(RVA = "0xCED170", Offset = "0xCEC570", VA = "0x180CED170")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public Success(Success other)
			{
			}

			[Token(Token = "0x600139D")]
			[Address(RVA = "0xCECA00", Offset = "0xCEBE00", VA = "0x180CECA00", Slot = "10")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public Success Clone()
			{
				return null;
			}

			[Token(Token = "0x60013A0")]
			[Address(RVA = "0xCECBF0", Offset = "0xCEBFF0", VA = "0x180CECBF0", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x60013A1")]
			[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(Success other)
			{
				return default(bool);
			}

			[Token(Token = "0x60013A2")]
			[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x60013A3")]
			[Address(RVA = "0xCECE90", Offset = "0xCEC290", VA = "0x180CECE90", Slot = "3")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x60013A4")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x60013A5")]
			[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x60013A6")]
			[Address(RVA = "0xCEC8E0", Offset = "0xCEBCE0", VA = "0x180CEC8E0", Slot = "7")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x60013A7")]
			[Address(RVA = "0xCECD70", Offset = "0xCEC170", VA = "0x180CECD70", Slot = "4")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(Success other)
			{
			}

			[Token(Token = "0x60013A8")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x60013A9")]
			[Address(RVA = "0xCED380", Offset = "0xCEC780", VA = "0x180CED380", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x4000681")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CharacterPresetCreateResponse> _parser;

	[Token(Token = "0x4000682")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000683")]
	public const int SuccessFieldNumber = 1;

	[Token(Token = "0x4000684")]
	public const int ErrorFieldNumber = 2;

	[Token(Token = "0x4000685")]
	[FieldOffset(Offset = "0x18")]
	private object result_;

	[Token(Token = "0x4000686")]
	[FieldOffset(Offset = "0x20")]
	private ResultOneofCase resultCase_;

	[Token(Token = "0x1700042C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<CharacterPresetCreateResponse> Parser
	{
		[Token(Token = "0x600137F")]
		[Address(RVA = "0xCD9CA0", Offset = "0xCD90A0", VA = "0x180CD9CA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700042D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001380")]
		[Address(RVA = "0xCD9B80", Offset = "0xCD8F80", VA = "0x180CD9B80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700042E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001381")]
		[Address(RVA = "0xCD9FE0", Offset = "0xCD93E0", VA = "0x180CD9FE0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700042F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.Success Success
	{
		[Token(Token = "0x6001385")]
		[Address(RVA = "0xCD9CF0", Offset = "0xCD90F0", VA = "0x180CD9CF0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001386")]
		[Address(RVA = "0x917DA0", Offset = "0x9171A0", VA = "0x180917DA0")]
		set
		{
		}
	}

	[Token(Token = "0x17000430")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.Error Error
	{
		[Token(Token = "0x6001387")]
		[Address(RVA = "0xCD9C30", Offset = "0xCD9030", VA = "0x180CD9C30")]
		get
		{
			return default(Types.Error);
		}
		[Token(Token = "0x6001388")]
		[Address(RVA = "0xCDA020", Offset = "0xCD9420", VA = "0x180CDA020")]
		set
		{
		}
	}

	[Token(Token = "0x17000431")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool HasError
	{
		[Token(Token = "0x6001389")]
		[Address(RVA = "0x92A010", Offset = "0x929410", VA = "0x18092A010")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000432")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ResultOneofCase ResultCase
	{
		[Token(Token = "0x600138B")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(ResultOneofCase);
		}
	}

	[Token(Token = "0x6001382")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterPresetCreateResponse()
	{
	}

	[Token(Token = "0x6001383")]
	[Address(RVA = "0xCD9A00", Offset = "0xCD8E00", VA = "0x180CD9A00")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterPresetCreateResponse(CharacterPresetCreateResponse other)
	{
	}

	[Token(Token = "0x6001384")]
	[Address(RVA = "0xCD9150", Offset = "0xCD8550", VA = "0x180CD9150", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharacterPresetCreateResponse Clone()
	{
		return null;
	}

	[Token(Token = "0x600138A")]
	[Address(RVA = "0x9295C0", Offset = "0x9289C0", VA = "0x1809295C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearError()
	{
	}

	[Token(Token = "0x600138C")]
	[Address(RVA = "0x916DD0", Offset = "0x9161D0", VA = "0x180916DD0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void ClearResult()
	{
	}

	[Token(Token = "0x600138D")]
	[Address(RVA = "0xCD9420", Offset = "0xCD8820", VA = "0x180CD9420", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600138E")]
	[Address(RVA = "0xCD9300", Offset = "0xCD8700", VA = "0x180CD9300", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(CharacterPresetCreateResponse other)
	{
		return default(bool);
	}

	[Token(Token = "0x600138F")]
	[Address(RVA = "0xCD9580", Offset = "0xCD8980", VA = "0x180CD9580", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001390")]
	[Address(RVA = "0xCD98A0", Offset = "0xCD8CA0", VA = "0x180CD98A0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001391")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001392")]
	[Address(RVA = "0xCD9EC0", Offset = "0xCD92C0", VA = "0x180CD9EC0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001393")]
	[Address(RVA = "0xCD9000", Offset = "0xCD8400", VA = "0x180CD9000", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001394")]
	[Address(RVA = "0xCD96B0", Offset = "0xCD8AB0", VA = "0x180CD96B0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CharacterPresetCreateResponse other)
	{
	}

	[Token(Token = "0x6001395")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001396")]
	[Address(RVA = "0xCD9D50", Offset = "0xCD9150", VA = "0x180CD9D50", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
