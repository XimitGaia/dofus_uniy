using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x20009FF")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class SubEntityInformation : IMessage<SubEntityInformation>, IMessage, IEquatable<SubEntityInformation>, IDeepCloneable<SubEntityInformation>, IBufferMessage
{
	[Token(Token = "0x2000A00")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x2000A01")]
		public enum BindingPointCategoryEnum
		{
			[Token(Token = "0x40023C6")]
			[OriginalName("HOOK_POINT_CATEGORY_UNUSED")]
			HookPointCategoryUnused = 0,
			[Token(Token = "0x40023C7")]
			[OriginalName("HOOK_POINT_CATEGORY_PET")]
			HookPointCategoryPet = 1,
			[Token(Token = "0x40023C8")]
			[OriginalName("HOOK_POINT_CATEGORY_MOUNT_DRIVER")]
			HookPointCategoryMountDriver = 2,
			[Token(Token = "0x40023C9")]
			[OriginalName("HOOK_POINT_CATEGORY_LIFTED_ENTITY")]
			HookPointCategoryLiftedEntity = 3,
			[Token(Token = "0x40023CA")]
			[OriginalName("HOOK_POINT_CATEGORY_BASE_BACKGROUND")]
			HookPointCategoryBaseBackground = 4,
			[Token(Token = "0x40023CB")]
			[OriginalName("HOOK_POINT_CATEGORY_BASE_FOREGROUND")]
			HookPointCategoryBaseForeground = 6,
			[Token(Token = "0x40023CC")]
			[OriginalName("HOOK_POINT_CATEGORY_UNDERWATER_BUBBLES")]
			HookPointCategoryUnderwaterBubbles = 7
		}
	}

	[Token(Token = "0x40023BD")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<SubEntityInformation> _parser;

	[Token(Token = "0x40023BE")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40023BF")]
	public const int BindingPointCategoryFieldNumber = 1;

	[Token(Token = "0x40023C0")]
	[FieldOffset(Offset = "0x18")]
	private Types.BindingPointCategoryEnum bindingPointCategory_;

	[Token(Token = "0x40023C1")]
	public const int BindingPointIndexFieldNumber = 2;

	[Token(Token = "0x40023C2")]
	[FieldOffset(Offset = "0x1C")]
	private int bindingPointIndex_;

	[Token(Token = "0x40023C3")]
	public const int SubEntityLookFieldNumber = 3;

	[Token(Token = "0x40023C4")]
	[FieldOffset(Offset = "0x20")]
	private EntityLook subEntityLook_;

	[Token(Token = "0x17001675")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<SubEntityInformation> Parser
	{
		[Token(Token = "0x600685E")]
		[Address(RVA = "0xBB1FF0", Offset = "0xBB13F0", VA = "0x180BB1FF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001676")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600685F")]
		[Address(RVA = "0xBB1F40", Offset = "0xBB1340", VA = "0x180BB1F40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001677")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6006860")]
		[Address(RVA = "0xBB2220", Offset = "0xBB1620", VA = "0x180BB2220", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001678")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.BindingPointCategoryEnum BindingPointCategory
	{
		[Token(Token = "0x6006864")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(Types.BindingPointCategoryEnum);
		}
		[Token(Token = "0x6006865")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17001679")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int BindingPointIndex
	{
		[Token(Token = "0x6006866")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006867")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x1700167A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EntityLook SubEntityLook
	{
		[Token(Token = "0x6006868")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006869")]
		[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
		set
		{
		}
	}

	[Token(Token = "0x6006861")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SubEntityInformation()
	{
	}

	[Token(Token = "0x6006862")]
	[Address(RVA = "0xBB1EC0", Offset = "0xBB12C0", VA = "0x180BB1EC0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SubEntityInformation(SubEntityInformation other)
	{
	}

	[Token(Token = "0x6006863")]
	[Address(RVA = "0xBB19E0", Offset = "0xBB0DE0", VA = "0x180BB19E0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SubEntityInformation Clone()
	{
		return null;
	}

	[Token(Token = "0x600686A")]
	[Address(RVA = "0xBB1A90", Offset = "0xBB0E90", VA = "0x180BB1A90", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600686B")]
	[Address(RVA = "0xBB1B50", Offset = "0xBB0F50", VA = "0x180BB1B50", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SubEntityInformation other)
	{
		return default(bool);
	}

	[Token(Token = "0x600686C")]
	[Address(RVA = "0xBB1BD0", Offset = "0xBB0FD0", VA = "0x180BB1BD0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600686D")]
	[Address(RVA = "0xBB1D60", Offset = "0xBB1160", VA = "0x180BB1D60", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600686E")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600686F")]
	[Address(RVA = "0xBB2180", Offset = "0xBB1580", VA = "0x180BB2180", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6006870")]
	[Address(RVA = "0xBB1900", Offset = "0xBB0D00", VA = "0x180BB1900", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6006871")]
	[Address(RVA = "0xBB1C80", Offset = "0xBB1080", VA = "0x180BB1C80", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SubEntityInformation other)
	{
	}

	[Token(Token = "0x6006872")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6006873")]
	[Address(RVA = "0xBB2040", Offset = "0xBB1440", VA = "0x180BB2040", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
