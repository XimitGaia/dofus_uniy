using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character.Management;

[Token(Token = "0x20008C7")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CharacterChangeBreedRequest : IMessage<CharacterChangeBreedRequest>, IMessage, IEquatable<CharacterChangeBreedRequest>, IDeepCloneable<CharacterChangeBreedRequest>, IBufferMessage
{
	[Token(Token = "0x4001E37")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CharacterChangeBreedRequest> _parser;

	[Token(Token = "0x4001E38")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001E39")]
	public const int BreedIdFieldNumber = 1;

	[Token(Token = "0x4001E3A")]
	[FieldOffset(Offset = "0x18")]
	private int breedId_;

	[Token(Token = "0x4001E3B")]
	public const int GenderFieldNumber = 2;

	[Token(Token = "0x4001E3C")]
	[FieldOffset(Offset = "0x1C")]
	private Gender gender_;

	[Token(Token = "0x4001E3D")]
	public const int ColorsFieldNumber = 3;

	[Token(Token = "0x4001E3E")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<int> _repeated_colors_codec;

	[Token(Token = "0x4001E3F")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<int> colors_;

	[Token(Token = "0x4001E40")]
	public const int CosmeticIdFieldNumber = 4;

	[Token(Token = "0x4001E41")]
	[FieldOffset(Offset = "0x28")]
	private int cosmeticId_;

	[Token(Token = "0x4001E42")]
	public const int ObjectIdFieldNumber = 5;

	[Token(Token = "0x4001E43")]
	[FieldOffset(Offset = "0x2C")]
	private int objectId_;

	[Token(Token = "0x170013B4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CharacterChangeBreedRequest> Parser
	{
		[Token(Token = "0x6005CD9")]
		[Address(RVA = "0xB16290", Offset = "0xB15690", VA = "0x180B16290")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013B5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005CDA")]
		[Address(RVA = "0xB161E0", Offset = "0xB155E0", VA = "0x180B161E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013B6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005CDB")]
		[Address(RVA = "0xB165B0", Offset = "0xB159B0", VA = "0x180B165B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013B7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BreedId
	{
		[Token(Token = "0x6005CDF")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6005CE0")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170013B8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Gender Gender
	{
		[Token(Token = "0x6005CE1")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(Gender);
		}
		[Token(Token = "0x6005CE2")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x170013B9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> Colors
	{
		[Token(Token = "0x6005CE3")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013BA")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CosmeticId
	{
		[Token(Token = "0x6005CE4")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6005CE5")]
		[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
		set
		{
		}
	}

	[Token(Token = "0x170013BB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ObjectId
	{
		[Token(Token = "0x6005CE6")]
		[Address(RVA = "0x95FBF0", Offset = "0x95EFF0", VA = "0x18095FBF0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6005CE7")]
		[Address(RVA = "0x960010", Offset = "0x95F410", VA = "0x180960010")]
		set
		{
		}
	}

	[Token(Token = "0x6005CDC")]
	[Address(RVA = "0xB16050", Offset = "0xB15450", VA = "0x180B16050")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharacterChangeBreedRequest()
	{
	}

	[Token(Token = "0x6005CDD")]
	[Address(RVA = "0xB160D0", Offset = "0xB154D0", VA = "0x180B160D0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterChangeBreedRequest(CharacterChangeBreedRequest other)
	{
	}

	[Token(Token = "0x6005CDE")]
	[Address(RVA = "0xB15A40", Offset = "0xB14E40", VA = "0x180B15A40", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterChangeBreedRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6005CE8")]
	[Address(RVA = "0xB15C30", Offset = "0xB15030", VA = "0x180B15C30", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005CE9")]
	[Address(RVA = "0xB15B80", Offset = "0xB14F80", VA = "0x180B15B80", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CharacterChangeBreedRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005CEA")]
	[Address(RVA = "0xB15D30", Offset = "0xB15130", VA = "0x180B15D30", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005CEB")]
	[Address(RVA = "0xB15EC0", Offset = "0xB152C0", VA = "0x180B15EC0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005CEC")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005CED")]
	[Address(RVA = "0xB16470", Offset = "0xB15870", VA = "0x180B16470", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005CEE")]
	[Address(RVA = "0xB158E0", Offset = "0xB14CE0", VA = "0x180B158E0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005CEF")]
	[Address(RVA = "0xB15E10", Offset = "0xB15210", VA = "0x180B15E10", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CharacterChangeBreedRequest other)
	{
	}

	[Token(Token = "0x6005CF0")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005CF1")]
	[Address(RVA = "0xB162E0", Offset = "0xB156E0", VA = "0x180B162E0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
