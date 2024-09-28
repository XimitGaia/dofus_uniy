using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic;

[Token(Token = "0x2000C19")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class OutfitUpdateRequest : IMessage<OutfitUpdateRequest>, IMessage, IEquatable<OutfitUpdateRequest>, IDeepCloneable<OutfitUpdateRequest>, IBufferMessage
{
	[Token(Token = "0x4002CDD")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<OutfitUpdateRequest> _parser;

	[Token(Token = "0x4002CDE")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002CDF")]
	public const int OutfitUuidFieldNumber = 1;

	[Token(Token = "0x4002CE0")]
	[FieldOffset(Offset = "0x18")]
	private string outfitUuid_;

	[Token(Token = "0x4002CE1")]
	public const int NameFieldNumber = 2;

	[Token(Token = "0x4002CE2")]
	[FieldOffset(Offset = "0x20")]
	private string name_;

	[Token(Token = "0x4002CE3")]
	public const int PictogramIdFieldNumber = 3;

	[Token(Token = "0x4002CE4")]
	[FieldOffset(Offset = "0x28")]
	private int pictogramId_;

	[Token(Token = "0x4002CE5")]
	public const int FavoriteFieldNumber = 4;

	[Token(Token = "0x4002CE6")]
	[FieldOffset(Offset = "0x2C")]
	private bool favorite_;

	[Token(Token = "0x17001BE8")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<OutfitUpdateRequest> Parser
	{
		[Token(Token = "0x6007F31")]
		[Address(RVA = "0xC695C0", Offset = "0xC689C0", VA = "0x180C695C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BE9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007F32")]
		[Address(RVA = "0xC69510", Offset = "0xC68910", VA = "0x180C69510")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BEA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007F33")]
		[Address(RVA = "0xC69830", Offset = "0xC68C30", VA = "0x180C69830", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BEB")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string OutfitUuid
	{
		[Token(Token = "0x6007F37")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007F38")]
		[Address(RVA = "0xC69980", Offset = "0xC68D80", VA = "0x180C69980")]
		set
		{
		}
	}

	[Token(Token = "0x17001BEC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Name
	{
		[Token(Token = "0x6007F39")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007F3A")]
		[Address(RVA = "0xC69910", Offset = "0xC68D10", VA = "0x180C69910")]
		set
		{
		}
	}

	[Token(Token = "0x17001BED")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PictogramId
	{
		[Token(Token = "0x6007F3B")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007F3C")]
		[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
		set
		{
		}
	}

	[Token(Token = "0x17001BEE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Favorite
	{
		[Token(Token = "0x6007F3D")]
		[Address(RVA = "0x9A7CA0", Offset = "0x9A70A0", VA = "0x1809A7CA0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6007F3E")]
		[Address(RVA = "0x9A8090", Offset = "0x9A7490", VA = "0x1809A8090")]
		set
		{
		}
	}

	[Token(Token = "0x6007F34")]
	[Address(RVA = "0xC693C0", Offset = "0xC687C0", VA = "0x180C693C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OutfitUpdateRequest()
	{
	}

	[Token(Token = "0x6007F35")]
	[Address(RVA = "0xC69430", Offset = "0xC68830", VA = "0x180C69430")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OutfitUpdateRequest(OutfitUpdateRequest other)
	{
	}

	[Token(Token = "0x6007F36")]
	[Address(RVA = "0xC68E50", Offset = "0xC68250", VA = "0x180C68E50", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public OutfitUpdateRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6007F3F")]
	[Address(RVA = "0xC68FF0", Offset = "0xC683F0", VA = "0x180C68FF0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007F40")]
	[Address(RVA = "0xC68F60", Offset = "0xC68360", VA = "0x180C68F60", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OutfitUpdateRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007F41")]
	[Address(RVA = "0xC690C0", Offset = "0xC684C0", VA = "0x180C690C0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007F42")]
	[Address(RVA = "0xC69260", Offset = "0xC68660", VA = "0x180C69260", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007F43")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007F44")]
	[Address(RVA = "0xC69750", Offset = "0xC68B50", VA = "0x180C69750", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007F45")]
	[Address(RVA = "0xC68D50", Offset = "0xC68150", VA = "0x180C68D50", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007F46")]
	[Address(RVA = "0xC691D0", Offset = "0xC685D0", VA = "0x180C691D0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OutfitUpdateRequest other)
	{
	}

	[Token(Token = "0x6007F47")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007F48")]
	[Address(RVA = "0xC69610", Offset = "0xC68A10", VA = "0x180C69610", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
