using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic;

[Token(Token = "0x2000C1F")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class OutfitDuplicateRequest : IMessage<OutfitDuplicateRequest>, IMessage, IEquatable<OutfitDuplicateRequest>, IDeepCloneable<OutfitDuplicateRequest>, IBufferMessage
{
	[Token(Token = "0x4002CF6")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<OutfitDuplicateRequest> _parser;

	[Token(Token = "0x4002CF7")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002CF8")]
	public const int OutfitUuidFieldNumber = 1;

	[Token(Token = "0x4002CF9")]
	[FieldOffset(Offset = "0x18")]
	private string outfitUuid_;

	[Token(Token = "0x4002CFA")]
	public const int NameFieldNumber = 2;

	[Token(Token = "0x4002CFB")]
	[FieldOffset(Offset = "0x20")]
	private string name_;

	[Token(Token = "0x4002CFC")]
	public const int PictogramIdFieldNumber = 3;

	[Token(Token = "0x4002CFD")]
	[FieldOffset(Offset = "0x28")]
	private int pictogramId_;

	[Token(Token = "0x17001BF9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OutfitDuplicateRequest> Parser
	{
		[Token(Token = "0x6007F7D")]
		[Address(RVA = "0xC613A0", Offset = "0xC607A0", VA = "0x180C613A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BFA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007F7E")]
		[Address(RVA = "0xC612F0", Offset = "0xC606F0", VA = "0x180C612F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BFB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007F7F")]
		[Address(RVA = "0xC61500", Offset = "0xC60900", VA = "0x180C61500", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BFC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string OutfitUuid
	{
		[Token(Token = "0x6007F83")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007F84")]
		[Address(RVA = "0xC61650", Offset = "0xC60A50", VA = "0x180C61650")]
		set
		{
		}
	}

	[Token(Token = "0x17001BFD")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string Name
	{
		[Token(Token = "0x6007F85")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007F86")]
		[Address(RVA = "0xC615E0", Offset = "0xC609E0", VA = "0x180C615E0")]
		set
		{
		}
	}

	[Token(Token = "0x17001BFE")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int PictogramId
	{
		[Token(Token = "0x6007F87")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007F88")]
		[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
		set
		{
		}
	}

	[Token(Token = "0x6007F80")]
	[Address(RVA = "0xC611A0", Offset = "0xC605A0", VA = "0x180C611A0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OutfitDuplicateRequest()
	{
	}

	[Token(Token = "0x6007F81")]
	[Address(RVA = "0xC61210", Offset = "0xC60610", VA = "0x180C61210")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public OutfitDuplicateRequest(OutfitDuplicateRequest other)
	{
	}

	[Token(Token = "0x6007F82")]
	[Address(RVA = "0xC60DD0", Offset = "0xC601D0", VA = "0x180C60DD0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public OutfitDuplicateRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6007F89")]
	[Address(RVA = "0xC60EE0", Offset = "0xC602E0", VA = "0x180C60EE0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007F8A")]
	[Address(RVA = "0xA5FC40", Offset = "0xA5F040", VA = "0x180A5FC40", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(OutfitDuplicateRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007F8B")]
	[Address(RVA = "0xA5FD90", Offset = "0xA5F190", VA = "0x180A5FD90", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007F8C")]
	[Address(RVA = "0xC61040", Offset = "0xC60440", VA = "0x180C61040", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007F8D")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007F8E")]
	[Address(RVA = "0xA603A0", Offset = "0xA5F7A0", VA = "0x180A603A0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007F8F")]
	[Address(RVA = "0xC60CE0", Offset = "0xC600E0", VA = "0x180C60CE0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007F90")]
	[Address(RVA = "0xC60FB0", Offset = "0xC603B0", VA = "0x180C60FB0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(OutfitDuplicateRequest other)
	{
	}

	[Token(Token = "0x6007F91")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007F92")]
	[Address(RVA = "0xC613F0", Offset = "0xC607F0", VA = "0x180C613F0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
