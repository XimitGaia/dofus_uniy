using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.House;

[Token(Token = "0x2000409")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class HousePropertiesEvent : IMessage<HousePropertiesEvent>, IMessage, IEquatable<HousePropertiesEvent>, IDeepCloneable<HousePropertiesEvent>, IBufferMessage
{
	[Token(Token = "0x4000DEC")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<HousePropertiesEvent> _parser;

	[Token(Token = "0x4000DED")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000DEE")]
	public const int HouseIdFieldNumber = 1;

	[Token(Token = "0x4000DEF")]
	[FieldOffset(Offset = "0x18")]
	private int houseId_;

	[Token(Token = "0x4000DF0")]
	public const int DoorsOnMapFieldNumber = 2;

	[Token(Token = "0x4000DF1")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<int> _repeated_doorsOnMap_codec;

	[Token(Token = "0x4000DF2")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<int> doorsOnMap_;

	[Token(Token = "0x4000DF3")]
	public const int PropertiesFieldNumber = 3;

	[Token(Token = "0x4000DF4")]
	[FieldOffset(Offset = "0x28")]
	private HouseInstance properties_;

	[Token(Token = "0x17000910")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HousePropertiesEvent> Parser
	{
		[Token(Token = "0x6002A6A")]
		[Address(RVA = "0x99EA10", Offset = "0x99DE10", VA = "0x18099EA10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000911")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002A6B")]
		[Address(RVA = "0x99E960", Offset = "0x99DD60", VA = "0x18099E960")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000912")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002A6C")]
		[Address(RVA = "0x99ED00", Offset = "0x99E100", VA = "0x18099ED00", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000913")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int HouseId
	{
		[Token(Token = "0x6002A70")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002A71")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000914")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> DoorsOnMap
	{
		[Token(Token = "0x6002A72")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000915")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public HouseInstance Properties
	{
		[Token(Token = "0x6002A73")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002A74")]
		[Address(RVA = "0x96C220", Offset = "0x96B620", VA = "0x18096C220")]
		set
		{
		}
	}

	[Token(Token = "0x6002A6D")]
	[Address(RVA = "0x99E8E0", Offset = "0x99DCE0", VA = "0x18099E8E0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HousePropertiesEvent()
	{
	}

	[Token(Token = "0x6002A6E")]
	[Address(RVA = "0x99E820", Offset = "0x99DC20", VA = "0x18099E820")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public HousePropertiesEvent(HousePropertiesEvent other)
	{
	}

	[Token(Token = "0x6002A6F")]
	[Address(RVA = "0x99E260", Offset = "0x99D660", VA = "0x18099E260", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HousePropertiesEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6002A75")]
	[Address(RVA = "0x99E3F0", Offset = "0x99D7F0", VA = "0x18099E3F0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002A76")]
	[Address(RVA = "0x99E340", Offset = "0x99D740", VA = "0x18099E340", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HousePropertiesEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002A77")]
	[Address(RVA = "0x99E4E0", Offset = "0x99D8E0", VA = "0x18099E4E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002A78")]
	[Address(RVA = "0x99E690", Offset = "0x99DA90", VA = "0x18099E690", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002A79")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002A7A")]
	[Address(RVA = "0x99EC00", Offset = "0x99E000", VA = "0x18099EC00", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002A7B")]
	[Address(RVA = "0x99E150", Offset = "0x99D550", VA = "0x18099E150", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002A7C")]
	[Address(RVA = "0x99E590", Offset = "0x99D990", VA = "0x18099E590", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(HousePropertiesEvent other)
	{
	}

	[Token(Token = "0x6002A7D")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002A7E")]
	[Address(RVA = "0x99EA60", Offset = "0x99DE60", VA = "0x18099EA60", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
