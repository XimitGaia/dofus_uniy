using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x20009C8")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CharacterRemodelingInformation : IMessage<CharacterRemodelingInformation>, IMessage, IEquatable<CharacterRemodelingInformation>, IDeepCloneable<CharacterRemodelingInformation>, IBufferMessage
{
	[Token(Token = "0x20009C9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x20009CA")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class CharacterToRemodelInformation : IMessage<CharacterToRemodelInformation>, IMessage, IEquatable<CharacterToRemodelInformation>, IDeepCloneable<CharacterToRemodelInformation>, IBufferMessage
		{
			[Token(Token = "0x40022AB")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<CharacterToRemodelInformation> _parser;

			[Token(Token = "0x40022AC")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x40022AD")]
			public const int PossibleChangeMaskFieldNumber = 1;

			[Token(Token = "0x40022AE")]
			[FieldOffset(Offset = "0x18")]
			private int possibleChangeMask_;

			[Token(Token = "0x40022AF")]
			public const int MandatoryChangeMaskFieldNumber = 2;

			[Token(Token = "0x40022B0")]
			[FieldOffset(Offset = "0x1C")]
			private int mandatoryChangeMask_;

			[Token(Token = "0x170015D5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageParser<CharacterToRemodelInformation> Parser
			{
				[Token(Token = "0x60065EF")]
				[Address(RVA = "0xB97E90", Offset = "0xB97290", VA = "0x180B97E90")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170015D6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x60065F0")]
				[Address(RVA = "0xB97E10", Offset = "0xB97210", VA = "0x180B97E10")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170015D7")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x60065F1")]
				[Address(RVA = "0xB97EE0", Offset = "0xB972E0", VA = "0x180B97EE0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170015D8")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int PossibleChangeMask
			{
				[Token(Token = "0x60065F5")]
				[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x60065F6")]
				[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
				set
				{
				}
			}

			[Token(Token = "0x170015D9")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int MandatoryChangeMask
			{
				[Token(Token = "0x60065F7")]
				[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x60065F8")]
				[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
				set
				{
				}
			}

			[Token(Token = "0x60065F2")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public CharacterToRemodelInformation()
			{
			}

			[Token(Token = "0x60065F3")]
			[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public CharacterToRemodelInformation(CharacterToRemodelInformation other)
			{
			}

			[Token(Token = "0x60065F4")]
			[Address(RVA = "0xB97B90", Offset = "0xB96F90", VA = "0x180B97B90", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public CharacterToRemodelInformation Clone()
			{
				return null;
			}

			[Token(Token = "0x60065F9")]
			[Address(RVA = "0xB97C20", Offset = "0xB97020", VA = "0x180B97C20", Slot = "0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x60065FA")]
			[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(CharacterToRemodelInformation other)
			{
				return default(bool);
			}

			[Token(Token = "0x60065FB")]
			[Address(RVA = "0x9691C0", Offset = "0x9685C0", VA = "0x1809691C0", Slot = "2")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x60065FC")]
			[Address(RVA = "0xB97CB0", Offset = "0xB970B0", VA = "0x180B97CB0", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x60065FD")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x60065FE")]
			[Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x60065FF")]
			[Address(RVA = "0xB97AD0", Offset = "0xB96ED0", VA = "0x180B97AD0", Slot = "7")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6006600")]
			[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CharacterToRemodelInformation other)
			{
			}

			[Token(Token = "0x6006601")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6006602")]
			[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x400229C")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CharacterRemodelingInformation> _parser;

	[Token(Token = "0x400229D")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400229E")]
	public const int NameFieldNumber = 1;

	[Token(Token = "0x400229F")]
	[FieldOffset(Offset = "0x18")]
	private string name_;

	[Token(Token = "0x40022A0")]
	public const int BreedIdFieldNumber = 2;

	[Token(Token = "0x40022A1")]
	[FieldOffset(Offset = "0x20")]
	private int breedId_;

	[Token(Token = "0x40022A2")]
	public const int GenderFieldNumber = 3;

	[Token(Token = "0x40022A3")]
	[FieldOffset(Offset = "0x24")]
	private Gender gender_;

	[Token(Token = "0x40022A4")]
	public const int ColorsFieldNumber = 4;

	[Token(Token = "0x40022A5")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<int> _repeated_colors_codec;

	[Token(Token = "0x40022A6")]
	[FieldOffset(Offset = "0x28")]
	private readonly RepeatedField<int> colors_;

	[Token(Token = "0x40022A7")]
	public const int CosmeticIdFieldNumber = 5;

	[Token(Token = "0x40022A8")]
	[FieldOffset(Offset = "0x30")]
	private int cosmeticId_;

	[Token(Token = "0x40022A9")]
	public const int CharacterToRemodelInformationFieldNumber = 6;

	[Token(Token = "0x40022AA")]
	[FieldOffset(Offset = "0x38")]
	private Types.CharacterToRemodelInformation characterToRemodelInformation_;

	[Token(Token = "0x170015CC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CharacterRemodelingInformation> Parser
	{
		[Token(Token = "0x60065D3")]
		[Address(RVA = "0xB97650", Offset = "0xB96A50", VA = "0x180B97650")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015CD")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60065D4")]
		[Address(RVA = "0xB975A0", Offset = "0xB969A0", VA = "0x180B975A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015CE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60065D5")]
		[Address(RVA = "0xB97A20", Offset = "0xB96E20", VA = "0x180B97A20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015CF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Name
	{
		[Token(Token = "0x60065D9")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x60065DA")]
		[Address(RVA = "0xB97A60", Offset = "0xB96E60", VA = "0x180B97A60")]
		set
		{
		}
	}

	[Token(Token = "0x170015D0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BreedId
	{
		[Token(Token = "0x60065DB")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60065DC")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x170015D1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Gender Gender
	{
		[Token(Token = "0x60065DD")]
		[Address(RVA = "0x87D140", Offset = "0x87C540", VA = "0x18087D140")]
		get
		{
			return default(Gender);
		}
		[Token(Token = "0x60065DE")]
		[Address(RVA = "0x9342C0", Offset = "0x9336C0", VA = "0x1809342C0")]
		set
		{
		}
	}

	[Token(Token = "0x170015D2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> Colors
	{
		[Token(Token = "0x60065DF")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015D3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CosmeticId
	{
		[Token(Token = "0x60065E0")]
		[Address(RVA = "0x875C10", Offset = "0x875010", VA = "0x180875C10")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60065E1")]
		[Address(RVA = "0x947120", Offset = "0x946520", VA = "0x180947120")]
		set
		{
		}
	}

	[Token(Token = "0x170015D4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.CharacterToRemodelInformation CharacterToRemodelInformation
	{
		[Token(Token = "0x60065E2")]
		[Address(RVA = "0x87D8A0", Offset = "0x87CCA0", VA = "0x18087D8A0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60065E3")]
		[Address(RVA = "0x91A5A0", Offset = "0x9199A0", VA = "0x18091A5A0")]
		set
		{
		}
	}

	[Token(Token = "0x60065D6")]
	[Address(RVA = "0xB973C0", Offset = "0xB967C0", VA = "0x180B973C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharacterRemodelingInformation()
	{
	}

	[Token(Token = "0x60065D7")]
	[Address(RVA = "0xB97460", Offset = "0xB96860", VA = "0x180B97460")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterRemodelingInformation(CharacterRemodelingInformation other)
	{
	}

	[Token(Token = "0x60065D8")]
	[Address(RVA = "0xB96C60", Offset = "0xB96060", VA = "0x180B96C60", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterRemodelingInformation Clone()
	{
		return null;
	}

	[Token(Token = "0x60065E4")]
	[Address(RVA = "0xB96DD0", Offset = "0xB961D0", VA = "0x180B96DD0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60065E5")]
	[Address(RVA = "0xB96EF0", Offset = "0xB962F0", VA = "0x180B96EF0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CharacterRemodelingInformation other)
	{
		return default(bool);
	}

	[Token(Token = "0x60065E6")]
	[Address(RVA = "0xB96FD0", Offset = "0xB963D0", VA = "0x180B96FD0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60065E7")]
	[Address(RVA = "0xB97230", Offset = "0xB96630", VA = "0x180B97230", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60065E8")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60065E9")]
	[Address(RVA = "0xB978B0", Offset = "0xB96CB0", VA = "0x180B978B0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60065EA")]
	[Address(RVA = "0xB96AC0", Offset = "0xB95EC0", VA = "0x180B96AC0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60065EB")]
	[Address(RVA = "0xB970D0", Offset = "0xB964D0", VA = "0x180B970D0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CharacterRemodelingInformation other)
	{
	}

	[Token(Token = "0x60065EC")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60065ED")]
	[Address(RVA = "0xB976A0", Offset = "0xB96AA0", VA = "0x180B976A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
